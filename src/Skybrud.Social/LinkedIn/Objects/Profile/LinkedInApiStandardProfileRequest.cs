using System.Collections.Generic;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInApiStandardProfileRequest {

        /// <summary>
        /// A URL representing the resource you would request for programmatic access to the member's profile.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// A collection of fields that can be re-used as HTTP headers to request an out of network profile programmatically.
        /// </summary>
        /// <remarks>
        /// Use the name returned as the name of an HTTP header with the value returned as it's value.
        /// </remarks>
        public LinkedInApiStandardProfileRequestHeaders[] Headers { get; set; }

    }

    public class LinkedInApiStandardProfileRequestHeaders {

        public string Name { get; set; }

        public string Value { get; set; }

    }
}
