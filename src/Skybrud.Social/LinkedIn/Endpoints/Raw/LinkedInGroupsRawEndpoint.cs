using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInGroupsRawEndpoint {

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInGroupsRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

    }
}
