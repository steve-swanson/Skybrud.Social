using Skybrud.Social.LinkedIn.Objects.Shared;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInCompany : LinkedInCompanyBase {

        /// <summary>
        /// Indicates if the company is public or private.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The industry in which the company operates.
        /// </summary>
        /// <remarks>
        /// Industry Codes found <see href="https://developer.linkedin.com/documents/industry-codes">here</see>.
        /// </remarks>
        public LinkedInIndustry Industry { get; set; }

        /// <summary>
        /// The stock market name for the company, if the company type is public.
        /// </summary>
        public string Ticker { get; set; }

    }
}
