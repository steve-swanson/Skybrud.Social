namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInSkill {

        /// <summary>
        /// A unique identifier for a single skill in the list of skills.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A structured object that indicates the internationalized name of the canonical language.
        /// </summary>
        public LinkedInSkillName Skill { get; set; }

    }

    public class LinkedInSkillName {

        /// <summary>
        /// The internationalized name of the canonical language.
        /// </summary>
        public string Name { get; set; }

    }

}
