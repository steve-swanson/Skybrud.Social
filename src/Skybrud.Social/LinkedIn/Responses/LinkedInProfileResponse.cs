using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Skybrud.Social.Json;
using Skybrud.Social.LinkedIn.Objects.Profile;

namespace Skybrud.Social.LinkedIn.Responses
{
    public class LinkedInProfileResponse : LinkedInResponse
    {
        #region Properties

        /// <summary>
        /// Gets the object representing the user.
        /// </summary>
        public LinkedInProfile Data { get; private set; }

        /// <summary>
        /// Gets the object representing the user (same as Data).
        /// </summary>
        public LinkedInProfile Profile
        {
            get { return Data; }
        }

        #endregion

        #region Constructors

        private LinkedInProfileResponse(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads an instance of <var>LinkedInProfileResponse</var> from
        /// the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static LinkedInProfileResponse LoadJson(string path)
        {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>LinkedInProfileResponse</var> from
        /// the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static LinkedInProfileResponse ParseJson(string json)
        {
            return JsonConverter.ParseObject(json, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>LinkedInProfileResponse</var> from
        /// the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static LinkedInProfileResponse Parse(JsonObject obj)
        {

            // Check if null
            if (obj == null) return null;

            // Validate the response
            ValidateResponse(obj);

            // Parse the response
            return new LinkedInProfileResponse(obj)
            {
                Data = obj.GetObject("data", LinkedInProfile.Parse)
            };

        }

        #endregion
    }
}
