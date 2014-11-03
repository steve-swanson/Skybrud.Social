using Skybrud.Social.LinkedIn.Endpoints.Raw;

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

        
        
        #endregion
    }
}
