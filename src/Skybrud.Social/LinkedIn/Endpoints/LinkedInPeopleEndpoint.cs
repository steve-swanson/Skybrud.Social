using Skybrud.Social.LinkedIn.Endpoints.Raw;
using Skybrud.Social.LinkedIn.Objects.Profile;

namespace Skybrud.Social.LinkedIn.Endpoints {

    public class LinkedInPeopleEndpoint {

        #region Properties

        public LinkedInService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public LinkedInPeopleRawEndpoint Raw {
            get { return Service.Client.People; }
        }

        #endregion

        #region Constructors

        internal LinkedInPeopleEndpoint(LinkedInService service) {
            Service = service;
        }

        #endregion

        #region Methods

        public LinkedInProfile GetProfile()
        {
            return LinkedInProfile.ParseJson(Raw.GetProfile());
        }

        public LinkedInProfile GetProfile(string id)
        {
            return LinkedInProfile.ParseJson(Raw.GetProfile(id));
        }

        #endregion
    }
}
