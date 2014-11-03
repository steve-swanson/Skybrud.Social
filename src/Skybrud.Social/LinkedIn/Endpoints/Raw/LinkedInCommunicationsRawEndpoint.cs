using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInCommunicationsRawEndpoint {

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInCommunicationsRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

    }
}
