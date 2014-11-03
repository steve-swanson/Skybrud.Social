namespace Skybrud.Social.LinkedIn {

    public class LinkedInScope {

        #region Constants

        #region Extended Permissions

        #region Read Permissions

        /// <summary>
        /// Name, photo, headline, and current positions (granted by default).
        /// </summary>
        public static readonly LinkedInScope ReadBasicProfile = new LinkedInScope(
            "r_basicprofile",
            "Name, photo, headline, and current positions (granted by default)."
        );

        /// <summary>
        /// Full profile including experience, education, skills, and recommendations.
        /// </summary>
        public static readonly LinkedInScope ReadFullProfile = new LinkedInScope(
            "r_fullprofile",
            "Full profile including experience, education, skills, and recommendations."
        );

        /// <summary>
        /// Your 1st and 2nd degree connections.
        /// </summary>
        public static readonly LinkedInScope ReadNetwork = new LinkedInScope(
            "r_network",
            "Your 1st and 2nd degree connections."
        );

        /// <summary>
        /// Address, phone number, and bound accounts.
        /// </summary>
        public static readonly LinkedInScope ReadContactInfo = new LinkedInScope(
            "r_contactinfo",
            "Address, phone number, and bound accounts."
        );

        #endregion

        #region Write Permissions

        /// <summary>
        /// Send messages and invitations to connect as you.
        /// </summary>
        public static readonly LinkedInScope WriteMessages = new LinkedInScope(
            "w_messages",
            "Send messages and invitations to connect as you."
        );

        #endregion

        #region Read/Write Permissions

        /// <summary>
            /// Retrieve and post group discussions as you.
        /// </summary>
        public static readonly LinkedInScope ReadWriteGroups = new LinkedInScope(
            "rw_groups",
            "Retrieve and post group discussions as you."
        );

        /// <summary>
        /// Retrieve and post updates to LinkedIn as you.
        /// </summary>
        public static readonly LinkedInScope ReadWriteNetworkUpdates = new LinkedInScope(
            "rw_nus",
            "Retrieve and post updates to LinkedIn as you."
        );

        /// <summary>
        /// Edit company pages for which I am an Admin and post status updates on behalf of those companies.
        /// </summary>
        public static readonly LinkedInScope ReadWriteCompanyAdmin = new LinkedInScope(
            "rw_company_admin",
            "Edit company pages for which I am an Admin and post status updates on behalf of those companies."
        );

        #endregion

        #endregion

        #region Email Permissions

        /// <summary>
        /// The primary email address you use for your LinkedIn account.
        /// </summary>
        public static readonly LinkedInScope EmailAddress = new LinkedInScope(
            "r_emailaddress",
            "The primary email address you use for your LinkedIn account."
        );
        
        #endregion

        #endregion

        #region Properties

        // The name of the scope
        public string Name { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default and private constructor.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        private LinkedInScope(string name, string description = null) {
            Name = name;
        }

        #endregion

        #region Member Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Adding two instance of LinkedInScope will result in a LinkedInScopeCollection containing both scopes.
        /// </summary>
        /// <param name="left">The left scope.</param>
        /// <param name="right">The right scope.</param>
        public static LinkedInScopeCollection operator +(LinkedInScope left, LinkedInScope right)
        {
            return new LinkedInScopeCollection(left, right);
        }

        #endregion
    
    }

}
