using System;
using Skybrud.Social.Json;
using Skybrud.Social.LinkedIn.Exceptions;

namespace Skybrud.Social.LinkedIn.Responses {

    public class LinkedInResponse : SocialJsonObject {
        
        #region Constructors

        protected LinkedInResponse(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static void ValidateResponse(JsonObject obj) {

            // Check whether "obj" is null
            if (obj == null) throw new ArgumentNullException("obj");

            // Get the "meta" object
            JsonObject meta = obj.GetObject("meta");

            // In special cases the root object is meta ()
            if (meta == null && obj.HasValue("code")) {
                meta = obj;
            }

            // In some special cases like during the OAuth authentication, the
            // root object is actually the "meta" object if any errors occur
            if (meta == null) {

                // Get some values from the "obj" object
                int code = obj.GetInt("code");
                string type = obj.GetString("error");
                string message = obj.GetString("error_description");

                if (obj.HasValue("code")) {
                    if (type == "OAuthException") throw new LinkedInOAuthException(code, type, message);
                    throw new LinkedInException(code, type, message);
                }

                // Should be OK by now
                return;

            }

            // Most responses will have a meta object along with a response code
            if (meta.HasValue("code")) {

                // Get some values from the "meta" object
                int code = meta.GetInt("code");
                string type = meta.GetString("error");
                string message = meta.GetString("error_description");

                // If "code" is 200, everything went fine :D
                if (code == 200) return;

                // Now throw some exceptions
                if (type == "OAuthException") throw new LinkedInOAuthException(code, type, message);
                if (type == "OAuthAccessTokenException") throw new LinkedInOAuthAccessTokenException(code, type, message);
                if (type == "APINotFoundError") throw new LinkedInNotFoundException(code, type, message);

                throw new LinkedInException(code, type, message);

            }

            throw new Exception("Invalid response received from server");

        }

        #endregion
    }
}
