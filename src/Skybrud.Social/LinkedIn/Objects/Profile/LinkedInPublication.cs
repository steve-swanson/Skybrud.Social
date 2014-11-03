using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInPublication {

        /// <summary>
        /// A unique identifier for this member's publication entry.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A string describing the title of this publication.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A string that indicates the name of the publisher of this publication.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// An array of structured objects describing authors for this publication.
        /// </summary>
        public LinkedInPublicationAuthor[] Authors { get; set; }

        /// <summary>
        /// A structured object with day, month, and year fields indicating when the publication was published.
        /// </summary>
        /// <remarks>
        /// Each individual field is optional, but if month is populated, year must be populated, if day is populated, month must be populated.
        /// </remarks>
        public LinkedInDate Date { get; set; }

        /// <summary>
        /// A URL for the publication.
        /// </summary>
        /// <remarks>
        /// Can either be the publication itself or a page with more information on the publication.
        /// </remarks>
        public string Url { get; set; }

        /// <summary>
        /// A string summary of the publication.
        /// </summary>
        public string Summary { get; set; }
    }

    public class LinkedInPublicationAuthor {

        /// <summary>
        /// A unique identifier for this author in the list of authors.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A string that indicates the name of this author as it should be displayed.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An optional field that displays the default LinkedIn member name (person field) for this particular member.
        /// </summary>
        public string Person { get; set; }
    }

}
