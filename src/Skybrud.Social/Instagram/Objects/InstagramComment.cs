using System;
using Skybrud.Social.Json;

namespace Skybrud.Social.Instagram.Objects {

    public class InstagramComment : SocialJsonObject {

        #region Properties
        
        /// <summary>
        /// The ID of the comment.
        /// </summary>
        public long Id { get; internal set; }

        /// <summary>
        /// The timestamp for when the comment was created.
        /// </summary>
        public DateTime Created { get; internal set; }

        /// <summary>
        /// The text/message of the comment.
        /// </summary>
        public string Text { get; internal set; }

        /// <summary>
        /// The user responsible for the comment.
        /// </summary>
        public InstagramUserSummary User { get; internal set; }

        #endregion

        #region Constructors

        private InstagramComment(JsonObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads a comment from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static InstagramComment LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a comment from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static InstagramComment ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a comment from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static InstagramComment Parse(JsonObject obj) {
            if (obj == null) return null;
            return new InstagramComment(obj) {
                Id = obj.GetLong("id"),
                Created = SocialUtils.GetDateTimeFromUnixTime(obj.GetLong("created_time")),
                Text = obj.GetString("text"),
                User = InstagramUserSummary.Parse(obj.GetObject("from"))
            };
        }

        #endregion

    }

}
