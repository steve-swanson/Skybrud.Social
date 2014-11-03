using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInPatent {
        
        /// <summary>
        /// A unique identifier for this member's patent entry.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The patent title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A short summary of the patent.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// A string with the patent or application number
        /// </summary>
        /// <remarks>
        /// Example: 7,720,722
        /// </remarks>
        public string Number { get; set; }

        /// <summary>
        /// A structured object describing the status of the patent.
        /// </summary>
        public LinkedInPatentStatus Status { get; set; }

        /// <summary>
        /// A structured object describing the patent issuing body.
        /// </summary>
        public LinkedInPatentOffice Office { get; set; }

        /// <summary>
        /// An array of structured objects describing the inventors for this patent.
        /// </summary>
        public LinkedInInventor[] Inventors { get; set; }

        /// <summary>
        /// A structured object with day, month, and year fields indicating when the application was filed or when the patent was granted.
        /// </summary>
        /// <remarks>
        /// Each individual field is optional, but if month is populated, year must be populated, if day is populated, month must be populated.
        /// </remarks>
        public LinkedInDate Date { get; set; }

        /// <summary>
        /// The URL to the patent.
        /// </summary>
        public string Url { get; set; }
    }

    public class LinkedInPatentOffice {
        public string Name { get; set; }
    }

    public class LinkedInPatentStatus {

        /// <summary>
        /// An ID indicating whether this is a granted patent or patent application.
        /// </summary>
        /// <remarks>
        /// Values are 0 for patent application; 1 for granted patent
        /// </remarks>
        public int Id { get; set; }

        /// <summary>
        /// A string indicating whether this is a granted patent or patent application.
        /// </summary>
        /// <remarks>
        /// Values are Application and Patent.
        /// </remarks>
        public string Name { get; set; }
    }

}
