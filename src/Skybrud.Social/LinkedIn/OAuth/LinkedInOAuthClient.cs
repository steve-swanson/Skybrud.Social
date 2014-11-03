using System;
using System.Collections.Specialized;
using System.Web;
using Skybrud.Social.LinkedIn.Endpoints.Raw;
using Skybrud.Social.LinkedIn.Responses;

namespace Skybrud.Social.LinkedIn.OAuth {

    /// <summary>
    /// Class for handling the raw communication with the LinkedIn API as well
    /// as any OAuth 2.0 communication/authentication.
    /// </summary>
    public class LinkedInOAuthClient {

        #region Private Fields

        private LinkedInCommunicationsRawEndpoint _communications;
        private LinkedInCompaniesRawEndpoint _companies;
        private LinkedInGroupsRawEndpoint _groups;
        private LinkedInJobsRawEndpoint _jobs;
        private LinkedInPeopleRawEndpoint _people;
        private LinkedInShareSocialRawEndpoint _shareSocial;

        #endregion

        #region Properties

        /// <summary>
        /// The API key of the app/client.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The secret key of the app/client.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// The redirect URI of your application.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// The access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets a reference to the communications endpoint.
        /// </summary>
        public LinkedInCommunicationsRawEndpoint Communications {
            get { return _communications ?? (_communications = new LinkedInCommunicationsRawEndpoint(this)); }
        }

        /// <summary>
        /// Gets a reference to the companies endpoint.
        /// </summary>
        public LinkedInCompaniesRawEndpoint Companies {
            get { return _companies ?? (_companies = new LinkedInCompaniesRawEndpoint(this)); }
        }

        /// <summary>
        /// Gets a reference to the groups endpoint.
        /// </summary>
        public LinkedInGroupsRawEndpoint Groups {
            get { return _groups ?? (_groups = new LinkedInGroupsRawEndpoint(this)); }
        }

        /// <summary>
        /// Gets a reference to the jobs endpoint.
        /// </summary>
        public LinkedInJobsRawEndpoint Jobs {
            get { return _jobs ?? (_jobs = new LinkedInJobsRawEndpoint(this)); }
        }

        /// <summary>
        /// Gets a reference to the people endpoint.
        /// </summary>
        public LinkedInPeopleRawEndpoint People {
            get { return _people ?? (_people = new LinkedInPeopleRawEndpoint(this)); }
        }

        /// <summary>
        /// Gets a reference to the share and social endpoint.
        /// </summary>
        public LinkedInShareSocialRawEndpoint ShareSocial {
            get { return _shareSocial ?? (_shareSocial = new LinkedInShareSocialRawEndpoint(this)); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an OAuth client with empty information.
        /// </summary>
        public LinkedInOAuthClient() {
            // default constructor
        }

        /// <summary>
        /// Initializes an OAuth client with the specified access token. Using this initializer,
        /// the client will have no information about your app.
        /// </summary>
        /// <param name="accessToken">A valid access token.</param>
        public LinkedInOAuthClient(string accessToken) {
            AccessToken = accessToken;
        }

        /// <summary>
        /// Initializes an OAuth client with the specified app ID and app secret.
        /// </summary>
        /// <param name="appId">The ID of the app.</param>
        /// <param name="appSecret">The secret of the app.</param>
        public LinkedInOAuthClient(long appId, string appSecret) {
            ClientId = appId + "";
            ClientSecret = appSecret;
        }

        /// <summary>
        /// Initializes an OAuth client with the specified app ID, app secret and return URI.
        /// </summary>
        /// <param name="appId">The ID of the app.</param>
        /// <param name="appSecret">The secret of the app.</param>
        /// <param name="redirectUri">The return URI of the app.</param>
        public LinkedInOAuthClient(long appId, string appSecret, string redirectUri) {
            ClientId = appId + "";
            ClientSecret = appSecret;
            RedirectUri = redirectUri;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an authorization URL using the specified <var>state</var>.
        /// This URL will only make your application request a basic scope.
        /// </summary>
        /// <param name="state">A unique state for the request.</param>
        public string GetAuthorizationUrl(string state) {
            return GetAuthorizationUrl(state, LinkedInScope.ReadBasicProfile);
        }

        /// <summary>
        /// Gets an authorization URL using the specified <var>state</var> and
        /// request the specified <var>scope</var>.
        /// </summary>
        /// <param name="state">A unique state for the request.</param>
        /// <param name="scope">The scope of your application.</param>
        public string GetAuthorizationUrl(string state, LinkedInScope scope) {
            return String.Format(
                "https://www.linkedin.com/uas/oauth2/authorization?response_type=code&client_id={0}&redirect_uri={1}&state={2}&scope={3}",
                HttpUtility.UrlEncode(ClientId),
                HttpUtility.UrlEncode(RedirectUri),
                HttpUtility.UrlEncode(state),
                HttpUtility.UrlEncode(scope.ToString().ToLower())
            );
        }

        /// <summary>
        /// Gets an authorization URL using the specified <var>state</var> and
        /// request the specified <var>scope</var>.
        /// </summary>
        /// <param name="state">A unique state for the request.</param>
        /// <param name="scope">The scope of your application.</param>
        public string GetAuthorizationUrl(string state, LinkedInScopeCollection scope)
        {
            return String.Format(
                "https://www.linkedin.com/uas/oauth2/authorization?response_type=code&client_id={0}&redirect_uri={1}&state={2}&scope={3}",
                HttpUtility.UrlEncode(ClientId),
                HttpUtility.UrlEncode(RedirectUri),
                HttpUtility.UrlEncode(state),
                HttpUtility.UrlEncode(scope.ToString().Replace(", ", "+").ToLower())
            );
        }

        public LinkedInAccessTokenResponse GetAccessTokenFromAuthCode(string authCode) {

            // Initialize collection with POST data
            NameValueCollection parameters = new NameValueCollection {
                {"grant_type", "authorization_code"},
                {"code", authCode },
                {"redirect_uri", RedirectUri},
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
            };

            // Make the call to the API
            string contents = SocialUtils.DoHttpPostRequestAndGetBodyAsString("https://www.linkedin.com/uas/oauth2/accessToken", null, parameters);

            // Parse the response
            return LinkedInAccessTokenResponse.ParseJson(contents);

        }

        #endregion

    }
}
