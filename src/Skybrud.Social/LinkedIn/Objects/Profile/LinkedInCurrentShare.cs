using Skybrud.Social.Json;

namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInCurrentShare : SocialJsonObject {

        public string Id { get; set; }
        public LinkedInCurrentShareAuthor Author { get; set; }
        public string Comment { get; set; }
        public LinkedInCurrentShareContent Content { get; set; }
        public LinkedInCurrentShareSource Source { get; set; }
        public long Timestamp { get; set; }
        public LinkedInCurrentShareVisibility Visibility { get; set; }

        #region Constructors

        private LinkedInCurrentShare(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShare Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShare(obj)
            {
                Id = obj.GetString("id") ?? string.Empty,
                Author = obj.GetObject("author", LinkedInCurrentShareAuthor.Parse),
                Comment = obj.GetString("comment"),
                Content = obj.GetObject("content", LinkedInCurrentShareContent.Parse),
                Source = obj.GetObject("source", LinkedInCurrentShareSource.Parse),
                Timestamp = obj.GetLong("timestamp"),
                Visibility = obj.GetObject("visibility", LinkedInCurrentShareVisibility.Parse)
            };
        }

    }

    public class LinkedInCurrentShareAuthor : SocialJsonObject {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Constructors

        private LinkedInCurrentShareAuthor(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareAuthor Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareAuthor(obj)
            {
                Id = obj.GetString("id") ?? string.Empty,
                FirstName = obj.GetString("firstName"),
                LastName = obj.GetString("lastName")
            };
        }
    }

    public class LinkedInCurrentShareContent : SocialJsonObject {

        public string Description { get; set; }
        public string EyebrowUrl { get; set; }
        public string ResolvedUrl { get; set; }
        public string ShortenedUrl { get; set; }
        public string SubmittedImageUrl { get; set; }
        public string SubmittedUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }

        #region Constructors

        private LinkedInCurrentShareContent(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareContent Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareContent(obj)
            {
                Description = obj.GetString("description"),
                EyebrowUrl = obj.GetString("eyebrowUrl"),
                ResolvedUrl = obj.GetString("resolvedUrl"),
                ShortenedUrl = obj.GetString("shortenedUrl"),
                SubmittedImageUrl = obj.GetString("submittedImageUrl"),
                SubmittedUrl = obj.GetString("submittedUrl"),
                ThumbnailUrl = obj.GetString("thumbnailUrl"),
                Title = obj.GetString("title")
            };
        }

    }

    public class LinkedInCurrentShareSource : SocialJsonObject {
        public LinkedInCurrentShareSourceApplication Application { get; set; }
        public LinkedInCurrentShareSourceServiceProvider ServiceProvider { get; set; }

        #region Constructors

        private LinkedInCurrentShareSource(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareSource Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareSource(obj)
            {
                Application = obj.GetObject("application", LinkedInCurrentShareSourceApplication.Parse),
                ServiceProvider = obj.GetObject("serviceProvider", LinkedInCurrentShareSourceServiceProvider.Parse)
            };
        }

    }

    public class LinkedInCurrentShareSourceApplication : SocialJsonObject {
        public string Name { get; set; }

        #region Constructors

        private LinkedInCurrentShareSourceApplication(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareSourceApplication Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareSourceApplication(obj)
            {
                Name = obj.GetString("name")
            };
        }
    }

    public class LinkedInCurrentShareSourceServiceProvider : SocialJsonObject {
        public string Name { get; set; }

        #region Constructors

        private LinkedInCurrentShareSourceServiceProvider(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareSourceServiceProvider Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareSourceServiceProvider(obj)
            {
                Name = obj.GetString("name")
            };
        }
    }

    public class LinkedInCurrentShareVisibility : SocialJsonObject {
        public string Code { get; set; }

        #region Constructors

        private LinkedInCurrentShareVisibility(JsonObject obj) : base(obj) { }

        #endregion

        public static LinkedInCurrentShareVisibility Parse(JsonObject obj)
        {
            if (obj == null) return null;
            return new LinkedInCurrentShareVisibility(obj)
            {
                Code = obj.GetString("code")
            };
        }
    }
}
