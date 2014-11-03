using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInPeopleRawEndpoint {

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInPeopleRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

    }
}
