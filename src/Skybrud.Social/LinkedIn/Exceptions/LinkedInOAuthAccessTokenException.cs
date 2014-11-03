namespace Skybrud.Social.LinkedIn.Exceptions {

    public class LinkedInOAuthAccessTokenException : LinkedInOAuthException {

        public LinkedInOAuthAccessTokenException(int code, string type, string message) : base(code, type, message) {
            // do nothing
        }

    }
}
