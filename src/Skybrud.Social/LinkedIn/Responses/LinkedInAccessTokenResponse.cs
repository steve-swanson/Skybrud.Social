using System;
using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Responses
{
    public class LinkedInAccessTokenResponse : LinkedInResponse {

        #region Properties

        /// <summary>
        /// The access token.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// The remaining lifetime on the access token.
        /// </summary>
        public TimeSpan ExpiresIn { get; private set; }

        /// <summary>
        /// Information about the authenticated user.
        /// </summary>
        //public LinkedInUser User { get; private set; }

        #endregion

        #region Constructors

        private LinkedInAccessTokenResponse(JsonObject obj) : base(obj) { }

        #endregion

        #region Static Methods

        /// <summary>
        /// Loads an instance of <var>LinkedInAccessTokenResponse</var> from
        /// the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static LinkedInAccessTokenResponse LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>LinkedInAccessTokenResponse</var> from
        /// the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static LinkedInAccessTokenResponse ParseJson(string json) {
            return JsonConverter.ParseObject(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>LinkedInAccessTokenResponse</var> from
        /// the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static LinkedInAccessTokenResponse Parse(JsonObject obj) {

            // Check if null
            if (obj == null) return null;

            // Validate the response
            ValidateResponse(obj);

            // Parse the response
            return new LinkedInAccessTokenResponse(obj) {
                ExpiresIn = TimeSpan.FromSeconds(obj.GetInt("expires_in")),
                AccessToken = obj.GetString("access_token")
            };

        }

        #endregion

    }
}
