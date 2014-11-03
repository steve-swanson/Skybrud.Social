using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInEducation {

        /// <summary>
        /// A unique identifier for this member's education entry.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The name of the school, as indicated by the member.
        /// </summary>
        public string SchoolName { get; set; }

        /// <summary>
        /// The field of study at the school, as indicated by the member.
        /// </summary>
        public string FieldOfStudy { get; set; }

        /// <summary>
        /// A structured object with a year field indicating when the education began.
        /// </summary>
        public LinkedInDate StartDate { get; set; }

        /// <summary>
        /// A structured object with a year field indicating when the education ended.
        /// </summary>
        /// <remarks>
        /// Blank when the education is current.
        /// </remarks>
        public LinkedInDate EndDate { get; set; }

        /// <summary>
        /// A string describing the degree, if any, received at this institution.
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// A string describing activities the member was involved in while a student at this institution.
        /// </summary>
        public string Activities { get; set; }

        /// <summary>
        /// A string describing other details on the member's studies.
        /// </summary>
        public string Notes { get; set; }

    }
}
