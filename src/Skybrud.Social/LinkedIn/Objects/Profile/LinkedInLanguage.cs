namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInLanguage {

        /// <summary>
        /// A unique identifier for a single language in the list of languages
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A structured object specifying the language name.
        /// </summary>
        /// <remarks>
        /// May be localized in the future.
        /// </remarks>
        public LinkedInLanguageName Language { get; set; }

        /// <summary>
        /// A structured object indicating the user's fluency.
        /// </summary>
        public LinkedInLanguageProficiency Proficiency { get; set; }

    }

    public class LinkedInLanguageName {

        /// <summary>
        /// The language name.
        /// </summary>
        /// <remarks>
        /// May be localized in the future.
        /// </remarks>
        public string Name { get; set; }

    }

    public class LinkedInLanguageProficiency {

        /// <summary>
        /// The user's fluency in the particular language - formatted for computers.
        /// </summary>
        /// <remarks>
        /// This field is for computer programs.
        /// 
        /// Returns one of the following five values:
        /// <list type="bullet">
        ///     <listheader>
        ///         <level>Level</level>
        ///     </listheader>
        ///     <item>
        ///         <level>elementary</level>
        ///         <level>limited-working</level>
        ///         <level>professional-working</level>
        ///         <level>full-professional</level>
        ///         <level>native-or-bilingual</level>
        ///     </item>
        /// </list>
        /// </remarks>
        public string Level { get; set; }

        /// <summary>
        /// The user's fluency in the particular language - formatted for people.
        /// </summary>
        /// <remarks>
        /// This field is for humans to read. It may be localized in the future.
        /// 
        /// Returns one of the following five values:
        /// <list type="bullet">
        ///     <listheader>
        ///         <level>Level</level>
        ///     </listheader>
        ///     <item>
        ///         <level>Elementary proficiency</level>
        ///         <level>Limited working proficiency</level>
        ///         <level>Professional working proficiency</level>
        ///         <level>Full professional proficiency</level>
        ///         <level>Native or bilingual proficiency</level>
        ///     </item>
        /// </list>
        /// </remarks>
        public string Name { get; set; }

    }

}
