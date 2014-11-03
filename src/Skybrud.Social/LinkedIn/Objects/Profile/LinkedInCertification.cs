using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInCertification {

        /// <summary>
        /// A unique identifier for this certification.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A string indicating the name of this certification.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A structured object containing the name of the certification's issuing body.
        /// </summary>
        public LinkedInCertificationAuthority Authority { get; set; }

        /// <summary>
        /// A string describing the license number for this certification.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// A structured object with day, month, and year fields indicating the start date for the certification.
        /// </summary>
        /// <remarks>
        /// Each individual field is optional, but if month is populated, year must be populated, if day is populated, month must be populated.
        /// </remarks>
        public LinkedInDate StartDate { get; set; }

        /// <summary>
        /// A structured object with day, month, and year fields indicating the start date for the certification.
        /// </summary>
        /// <remarks>
        /// Each individual field is optional, but if month is populated, year must be populated, if day is populated, month must be populated.
        /// </remarks>
        public LinkedInDate EndDate { get; set; }

    }

    public class LinkedInCertificationAuthority {

        /// <summary>
        /// The name of the certification's issuing body.
        /// </summary>
        public string Name { get; set; }

    }

}
