using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInLocation : SocialJsonObject {

        /// <summary>
        /// Generic name of the location of the LinkedIn member, (ex: "San Francisco Bay Area").
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country code for the LinkedIn member.
        /// </summary>
        /// <remarks>
        /// Lower case values as defined by ISO 3166-1 alpha-2 standard.
        /// </remarks>
        public LinkedInCountry Country { get; set; }

        #region Constructors

        private LinkedInLocation(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInLocation Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInLocation(obj)
            {
                Name = obj.GetString("name"),
                Country = obj.GetObject("country", LinkedInCountry.Parse)
            };
        }
    }

    public class LinkedInCountry : SocialJsonObject {

        public string Code { get; set; }

        #region Constructors

        private LinkedInCountry(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCountry Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCountry(obj)
            {
                Code = obj.GetString("code"),
            };
        }

    }
}
