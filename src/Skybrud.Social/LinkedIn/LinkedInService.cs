using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Skybrud.Social.LinkedIn.Endpoints;
using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn
{
    public class LinkedInService
    {

        #region Properties

        /// <summary>
        /// The internal OAuth client for communication with the LinkedIn API.
        /// </summary>
        public LinkedInOAuthClient Client { get; private set; }

        public LinkedInPeopleEndpoint People { get; private set; }

        #endregion

        #region Constructors

        private LinkedInService() {
            
            People = new LinkedInPeopleEndpoint(this);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new service instance from the specified access token. Internally a new OAuth client will be
        /// initialized from the access token.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        public static LinkedInService CreateFromAccessToken(string accessToken) {
            
            return new LinkedInService() {
                Client = new LinkedInOAuthClient(accessToken)
            };
        }

        /// <summary>
        /// Initialize a new service instance from the specified OAuth client.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        public static LinkedInService CreateFromOAuthClient(LinkedInOAuthClient client) {

            // This should never be null
            if (client == null) throw new ArgumentNullException("client");

            // Initialize the service
            return new LinkedInService {
                Client = client
            };

        }

        #endregion
    }
}
