using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInPosition : SocialJsonObject {

        /// <summary>
        /// A unique identifier for this member's position.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The job title held at the position, as indicated by the member.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A summary of the member's position.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// A structured object with month and year fields indicating when the position began.
        /// </summary>
        public LinkedInPositionDate StartDate { get; set; }

        /// <summary>
        /// A structured object with month and year fields indicating when the position ended.
        /// </summary>
        public LinkedInPositionDate EndDate { get; set; }

        /// <summary>
        /// A "true" or "false" value, depending on whether it is marked current.
        /// </summary>
        public bool IsCurrent { get; set; }

        /// <summary>
        /// The company the member works for.
        /// </summary>
        public LinkedInCompany Company { get; set; }

        #region Constructors

        private LinkedInPosition(JsonObject obj) : base(obj) { }

        #endregion

        //public static LinkedInPosition[] Parse(JsonObject obj)
        //{
        //    if (obj == null) return null;



        //    return new LinkedInPosition(obj)
        //    {
        //        Name = obj.GetString("name"),
        //        Country = obj.GetObject("country", LinkedInCountry.Parse)
        //    };
        //}

    }

    public class LinkedInPositionDate : SocialJsonObject {
        public int Month { get; set; }
        public int Year { get; set; }

        #region Constructors

        private LinkedInPositionDate(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInPositionDate Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInPositionDate(obj)
            {
                Month = obj.GetInt("month"),
                Year = obj.GetInt("yonth")
            };
        }

    }

}
