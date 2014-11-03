namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInVolunteer {
        
        /// <summary>
        /// A unique identifier for this member's volunteer entries.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The role the member has performed as a volunteer.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// The name of an organization the member has volunteered with.
        /// </summary>
        public LinkedInVolunteerOrganization Organization { get; set; }

        /// <summary>
        /// The causes the member has listed.
        /// </summary>
        public LinkedInVolunteerCause Cause { get; set; }

    }

    public class LinkedInVolunteerOrganization {

        /// <summary>
        /// The name of an organization the member has volunteered with.
        /// </summary>
        public string Name { get; set; }

    }

    public class LinkedInVolunteerCause {

        /// <summary>
        /// A string describing causes the member has listed.
        /// </summary>
        public string Name { get; set; }

    }

}
