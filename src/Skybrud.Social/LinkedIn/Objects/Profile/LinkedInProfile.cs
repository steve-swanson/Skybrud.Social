using System;
using Newtonsoft.Json;
using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInProfile : SocialJsonObject
    {

        #region Basic Profile Properties

        /// <summary>
        /// A unique identifier token for this member
        /// </summary>
        /// <remarks>
        /// This field might return a value of private for users other than the currently logged-in user depending on the member's privacy settings.
        /// </remarks>
        public string Id { get; set; }

        /// <summary>
        /// The member's first name.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results depending on the member's privacy settings.
        /// </remarks>
        public string FirstName { get; set; }

        /// <summary>
        /// The member's last name.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results or return a value of private, depending on the member's privacy settings.
        /// </remarks>
        public string LastName { get; set; }

        /// <summary>
        /// The member's maiden name.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results or return a value of private, depending on the member's privacy settings.
        /// </remarks>
        public string MaidenName { get; set; }

        /// <summary>
        /// The member's name formatted based on language.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results or return a value of private, depending on the member's privacy settings.
        /// </remarks>
        public string FormattedName { get; set; }

        /// <summary>
        /// The member's first name spelled phonetically.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results depending on the member's privacy settings.
        /// </remarks>
        public string PhoneticFirstName { get; set; }

        /// <summary>
        /// The member's last name spelled phonetically.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results depending on the member's privacy settings.
        /// </remarks>
        public string PhoneticLastName { get; set; }

        /// <summary>
        /// The member's name spelled phonetically and formatted based on language.
        /// </summary>
        /// <remarks>
        /// This field might be omitted from some results or return a value of private, depending on the member's privacy settings.
        /// </remarks>
        public string FormattedPhoneticName { get; set; }

        /// <summary>
        /// The member's headline (often "Job Title at Company").
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// A URL to the profile picture, if the member has associated one with their profile and it is visible to the requestor.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Location of the LinkedIn member.
        /// </summary>
        public LinkedInLocation Location { get; set; }

        /// <summary>
        /// The industry the LinkedIn member has indicated their profile belongs to.
        /// </summary>
        /// <remarks>
        /// Industry Codes found <see href="https://developer.linkedin.com/documents/industry-codes">here</see>.
        /// </remarks>
        public string Industry { get; set; }

        /// <summary>
        /// The degree distance of the fetched profile from the member who fetched the profile.
        /// </summary>
        /// <remarks>
        /// Values are:
        /// <list type="bullet">
        ///     <listheader>
        ///         <distance>distance</distance>
        ///         <description>descripion</description>
        ///     </listheader>
        ///     <item>
        ///         <distance>0</distance>
        ///         <description>The member</description>
        ///     </item>
        ///     <item>
        ///         <distance>1, 2, and 3</distance>
        ///         <description>Number of degrees apart.</description>
        ///     </item>
        ///     <item>
        ///         <distance>-1</distance>
        ///         <description>Out of network.</description>
        ///     </item>
        ///     <item>
        ///         <distance>100</distance>
        ///         <description>Share a group, but not within 3 degrees (would get 1-3 instead).</description>
        ///     </item>
        /// </list>
        /// </remarks>
        public int Distance { get; set; }

        /// <summary>
        /// The member's current share, if set.
        /// </summary>
        /// <remarks>
        /// Overloaded to also return "current-status" (if there is no URL shared).
        /// </remarks>
        public LinkedInCurrentShare CurrentShare { get; set; }

        /// <summary>
        /// The number of connections the member has.
        /// </summary>
        /// <remarks>
        /// Available in some places, such as /people/~/connections, when connections is not. More efficient than checking the total attribute of connections even when connections is available.
        /// </remarks>
        public int NumConnections { get; set; }

        /// <summary>
        /// <value>true</value> if the value of num-connections has been capped at 500, otherwise <value>false</value>.
        /// </summary>
        /// <remarks>
        /// Allows you to distinguish whether num-connections = 500 because the member has exactly 500 connections or actually 500+ because we're hiding the true value.
        /// </remarks>
        public bool NumConnectionsCapped { get; set; }

        /// <summary>
        /// A long-form text area where the member describes their professional profile.
        /// </summary>
        /// <remarks>
        /// Not available via connections API.
        /// </remarks>
        public string Summary { get; set; }

        /// <summary>
        /// A short-form text area where the member enumerates their specialties.
        /// </summary>
        /// <remarks>
        /// Not available via connections API.
        /// </remarks>
        public string Specialties { get; set; }

        /// <summary>
        /// A collection of positions a member has had, the total indicated by a total attribute
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#positions">Positions Fields</see>.
        /// Only current positions are available for people other than the authenticated member.
        /// </remarks>
        public LinkedInPosition[] Positions { get; set; }

        /// <summary>
        /// Information pertaining to viewing the member's authenticated profile.
        /// </summary>
        public LinkedInSiteStandardProfileRequest SiteStandardProfileRequest { get; set; }

        /// <summary>
        /// Resource and fields necessary to issue a request for programmatic access to the member's profile.
        /// </summary>
        public LinkedInApiStandardProfileRequest ApiStandardProfileRequest { get; set; }

        /// <summary>
        /// A URL to the member's public profile, if enabled.
        /// </summary>
        /// <remarks>
        /// This field is only available when requested using a field selector in a profile or connections call.
        /// </remarks>
        public string PublicProfileUrl { get; set; }

        #endregion

        #region Full Profile Properties

        [JsonIgnore]
        private long _lastModifiedTimestamp;

        [JsonIgnore]
        private DateTime _lastModifiedTimestampReadable;

        /// <summary>
        /// The timestamp, in milliseconds since the Unix epoch, when the member's profile was last edited.
        /// </summary>
        public long LastModifiedTimestamp {
            get { return _lastModifiedTimestamp; }
            private set { _lastModifiedTimestamp = value; LastModifiedTimestampReadable = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddMilliseconds(value); }
        }

        /// <summary>
        /// The timestamp, as a human-readable date/time, when the member's profile was last edited.
        /// </summary>
        [JsonIgnore]
        public DateTime LastModifiedTimestampReadable {
            get { return _lastModifiedTimestampReadable; }
            private set { _lastModifiedTimestampReadable = value; }
        }

        /// <summary>
        /// Member's birth date.
        /// </summary>
        /// <remarks>
        /// May return only month and day, but not year, or all three, depending on information provided. The year will be 1970 if only month and day are available.
        /// </remarks>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// A collection of positions a member currently holds, limited to three and indicated by a total attribute.
        /// </summary>
        /// <remarks>
        /// You can use the <positions> collection to get the full set or use this collection to limit the return to just the first three positions.
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#positions">Positions Fields</see>.
        /// </remarks>
        public LinkedInPosition[] ThreeCurrentPositions { get; set; }

        /// <summary>
        /// A collection of positions a member formerly held, limited to the three most recent and indicated by a total attribute.
        /// </summary>
        /// <remarks>
        /// You can use the <positions> collection to get the full set or use  this collection to limit the return to just the first three positions.
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#positions">Positions Fields</see>.
        /// </remarks>
        public LinkedInPosition[] ThreePastPositions { get; set; }

        /// <summary>
        /// Contains brief connection/person objects indicating the connecting first degree members.
        /// </summary>
        public LinkedInConnection[] Connections { get; set; }

        /// <summary>
        /// A short-form text area describing how the member approaches proposals.
        /// </summary>
        public string ProposalComments { get; set; }

        /// <summary>
        /// A short-form text area enumerating the associations a member has.
        /// </summary>
        public string Associations { get; set; }

        /// <summary>
        /// A short-form text area describing the member's interests.
        /// </summary>
        public string Interests { get; set; }

        /// <summary>
        /// A collection of publications authored by this member
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#publications">Publications Fields</see>.
        /// </remarks>
        public LinkedInPublication[] Publications { get; set; }

        /// <summary>
        /// A collection of patents or patent applications held by this member.
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#patents">Patents Fields</see>.
        /// </remarks>
        public LinkedInPatent[] Patents { get; set; }

        /// <summary>
        /// A collection of languages and the level of the member's proficiency for each.
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#languages">Languages Fields</see>.
        /// </remarks>
        public LinkedInLanguage[] Languages { get; set; }

        /// <summary>
        /// A collection of skills held by this member
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#skills">Skills Fields</see>.
        /// </remarks>
        public LinkedInSkill[] Skills { get; set; }

        /// <summary>
        /// A collection of certifications earned by this member.
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#certifications">Certifications Fields</see>.
        /// </remarks>
        public LinkedInCertification[] Certifications { get; set; }

        /// <summary>
        /// A collection of education institutions a member has attended, the total indicated by a total attribute
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#educations">Educations Fields</see>.
        /// </remarks>
        public LinkedInEducation[] Educations { get; set; }

        /// <summary>
        /// A collection of courses a member has taken, the total indicated by a total attribute.
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#courses">Courses Fields</see>.
        /// </remarks>
        public LinkedInCourse[] Courses { get; set; }

        /// <summary>
        /// A collection of volunteering experiences a member has participated in, including organizations and causes, the totals indicated by a total attribute.
        /// </summary>
        /// <remarks>
        /// See <see href="https://developer.linkedin.com/documents/profile-fields#volunteer">Volunteer Experience Fields</see>.
        /// </remarks>
        public LinkedInVolunteer[] Volunteer { get; set; }

        /// <summary>
        /// The number of recommendations the member has.
        /// </summary>
        public int NumRecommenders { get; set; }

        /// <summary>
        /// A collection of recommendations a member has received.
        /// </summary>
        public LinkedInRecommendation[] RecommendationsReceived { get; set; }

        /// <summary>
        /// A collection of people, company, and industries suggested for the member to follow.
        /// </summary>
        public LinkedInFollowAndSuggestion Suggestions { get; set; }

        #endregion

        #region Constructors

        private LinkedInProfile(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads a profile from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static LinkedInProfile LoadJson(string path)
        {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a profile from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static LinkedInProfile ParseJson(string json)
        {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a profile from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static LinkedInProfile Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInProfile(obj)
            {
                Id = obj.GetString("id"),
                FirstName = obj.GetString("firstName"),
                LastName = obj.GetString("lastName"),
                MaidenName = obj.GetString("maidenName"),
                FormattedName = obj.GetString("formattedName"),
                PhoneticFirstName = obj.GetString("phoneticFirstName"),
                PhoneticLastName = obj.GetString("phoneticLastName"),
                FormattedPhoneticName = obj.GetString("formattedPhoneticName"),
                Headline = obj.GetString("headline"),
                PictureUrl = obj.GetString("pictureUrl"),
                Location = obj.GetObject("location", LinkedInLocation.Parse),
                Industry = obj.GetString("industry"),
                Distance = obj.GetInt("distance"),
                CurrentShare = obj.GetObject("currentShare", LinkedInCurrentShare.Parse),
                NumConnections = obj.GetInt("numConnections"),
                NumConnectionsCapped = obj.GetBoolean("numConnectionsCapped"),
                Summary = obj.GetString("summary"),
                Specialties = obj.GetString("specialties")//,
                //Positions = obj.GetObject("positions", LinkedInPosition.Parse)
            };
        }

        #endregion
    }
}
