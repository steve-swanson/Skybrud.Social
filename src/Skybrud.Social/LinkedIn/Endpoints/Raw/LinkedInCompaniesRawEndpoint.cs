using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInCompaniesRawEndpoint {

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInCompaniesRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

    }
}
