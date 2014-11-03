﻿namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInInventor {

        /// <summary>
        /// A unique identifier for this inventor in the list of inventors.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A string that indicates the name of this inventor as it should be displayed.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An optional field that shows the LinkedIn member object for this particular member.
        /// </summary>
        /// <remarks>
        /// Default values are id, first-name, and last-name
        /// </remarks>
        public LinkedInProfile Person { get; set; }

    }
}
