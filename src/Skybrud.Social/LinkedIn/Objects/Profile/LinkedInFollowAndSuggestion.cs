namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInFollowAndSuggestion {

        /// <summary>
        /// A collection of companies the user is suggested to follow.
        /// </summary>
        public LinkedInCompanyBase[] Companies { get; set; }

        /// <summary>
        /// A collection of industries the user is suggested to follow.
        /// </summary>
        public LinkedInIndustryBase[] Industries { get; set; }

        /// <summary>
        /// A collection of news sources the user is suggested to follow.
        /// </summary>
        public LinkedInSuggestionNewsSource[] NewsSources { get; set; }

        /// <summary>
        /// A collection of people the user is suggested to follow.
        /// </summary>
        public LinkedInSuggestionPerson[] People { get; set; }

    }

    // TODO: Get proper fields. Nothing was returned in query and fields not detailed in API documentation.
    /// <summary>
    /// A news source the user is suggested to follow.
    /// </summary>
    public class LinkedInSuggestionNewsSource {
        public int Id { get; set; }
        //public string Name { get; set; }
    }

    // TODO: Get proper fields. Nothing was returned in query and fields not detailed in API documentation.
    /// <summary>
    /// A person the user is suggested to follow.
    /// </summary>
    public class LinkedInSuggestionPerson {
        public int Id { get; set; }
        //public string Name { get; set; }
    }

}
