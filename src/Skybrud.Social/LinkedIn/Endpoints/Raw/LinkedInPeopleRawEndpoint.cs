using System;
using System.Collections.Specialized;
using System.Globalization;
using Skybrud.Social.LinkedIn.OAuth;

namespace Skybrud.Social.LinkedIn.Endpoints.Raw {

    public class LinkedInPeopleRawEndpoint
    {

        private readonly string _profileFields = "(id,first-name,last-name,maiden-name,formatted-name,phonetic-first-name,phonetic-last-name,formatted-phonetic-name,headline,picture-url,location,industry,distance,current-share,num-connections,num-connections-capped,summary,specialties)";

        #region Properties

        public LinkedInOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal LinkedInPeopleRawEndpoint(LinkedInOAuthClient client) {
            Client = client;
        }

        #endregion

        public string GetProfile()
        {
            var qs = new NameValueCollection();
            qs.Add("format", "json");
            qs.Add("oauth2_access_token", Client.AccessToken);
            return Client.DoLinkedInGetRequestAsString("https://api.linkedin.com/v1/people/~:" + _profileFields, qs);
        }

        public string GetProfile(string id)
        {
            var qs = new NameValueCollection();
            qs.Add("format", "json");
            qs.Add("oauth2_access_token", Client.AccessToken);



            return Client.DoLinkedInGetRequestAsString(String.Format("https://api.linkedin.com/v1/people/id={0}:{1}", id, _profileFields), qs);
        }
    }
}
