using Skybrud.Social.Instagram.Exceptions;

namespace Skybrud.Social.LinkedIn.Exceptions {

    public class LinkedInNotFoundException : InstagramException {

        internal LinkedInNotFoundException(int code, string type, string message) : base(code, type, message) {
            // do nothing
        }

    }

}
