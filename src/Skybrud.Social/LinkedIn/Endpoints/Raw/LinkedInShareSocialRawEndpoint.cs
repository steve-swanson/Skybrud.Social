using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInShareSocialRawEndpoint {

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInShareSocialRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

    }
}
