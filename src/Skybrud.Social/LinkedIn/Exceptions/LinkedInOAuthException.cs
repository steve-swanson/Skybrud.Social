namespace Skybrud.Social.LinkedIn.Exceptions {

    public class LinkedInOAuthException : LinkedInException {

        public LinkedInOAuthException(int code, string type, string message) : base(code, type, message) {
            // do nothing
        }

    }
}
