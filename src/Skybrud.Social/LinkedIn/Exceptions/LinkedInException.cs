using System;
using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Exceptions {

    public class LinkedInException : Exception {

        public int Code { get; private set; }
        public string Type { get; private set; }

        internal LinkedInException(int code, string type, string message) : base(message) {
            Code = code;
            Type = type;
        }

        internal LinkedInException(JsonObject obj) : base(obj.GetString("error_description")) {
            Code = obj.GetInt("code");
            Type = obj.GetString("error_type");
        }

    }
}
