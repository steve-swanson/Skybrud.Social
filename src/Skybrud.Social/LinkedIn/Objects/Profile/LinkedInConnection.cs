using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInConnection {

        /// <summary>
        /// A unique identifier token for this member.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The member's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The member's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The member's headline (often "Job Title at Company").
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// A URL to the profile picture, if the member has associated one with their profile and it is visible to the requestor.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// The industry the LinkedIn member has indicated their profile belongs to.
        /// </summary>
        /// <remarks>
        /// Industry Codes found <see href="https://developer.linkedin.com/documents/industry-codes">here</see>.
        /// </remarks>
        public LinkedInIndustry Industry { get; set; }

        /// <summary>
        /// Location of the LinkedIn member.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Resource and fields necessary to issue a request for programmatic access to the member's profile.
        /// </summary>
        public LinkedInApiStandardProfileRequest ApiStandardProfileRequest { get; set; }

        /// <summary>
        /// Information pertaining to viewing the member's authenticated profile.
        /// </summary>
        public LinkedInSiteStandardProfileRequest SiteStandardProfileRequest { get; set; }

    }
}
