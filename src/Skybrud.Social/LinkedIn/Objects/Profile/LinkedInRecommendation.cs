namespace Skybrud.Social.LinkedIn.Objects.Profile {

    public class LinkedInRecommendation {

        /// <summary>
        /// A unique identifier for this recommendation.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Indicates type of recommendation that was selected by the person making the recommendation.
        /// </summary>
        public string RecommendationType { get; set; }

        /// <summary>
        /// The text of the recommendation received.
        /// </summary>
        public string RecommendationText { get; set; }

        /// <summary>
        /// A collection defining the person who made the recommendation.
        /// </summary>
        public LinkedInProfile Recommender { get; set; }

    }
}
