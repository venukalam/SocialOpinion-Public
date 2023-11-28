using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialOpinionAPI.DTO.Timeline
{

    public class UserReverseChronologicalTimelineDTO
    {
        public RCTimelineDatum[] data { get; set; }
        public RCTimelineIncludes includes { get; set; }
        public RCTimelineError[] errors { get; set; }
        public RCTimelineMeta meta { get; set; }
    }

    public class RCTimelineIncludes
    {
        public RCTimelineMedium[] media { get; set; }
        public RCTimelineUser[] users { get; set; }
        public RCTimelineTweet[] tweets { get; set; }
    }

    public class RCTimelineMedium
    {
        public int duration_ms { get; set; }
        public string media_key { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public string preview_image_url { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class RCTimelineUser
    {
        public string description { get; set; }
        public Public_Metrics public_metrics { get; set; }
        public string id { get; set; }
        public string pinned_tweet_id { get; set; }
        public string location { get; set; }
        public DateTime created_at { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public bool _protected { get; set; }
        public RCTimelineEntities entities { get; set; }
        public bool verified { get; set; }
        public string name { get; set; }
        public string profile_image_url { get; set; }
    }

    public class Public_Metrics
    {
        public int followers_count { get; set; }
        public int following_count { get; set; }
        public int tweet_count { get; set; }
        public int listed_count { get; set; }
        public int like_count { get; set; }
    }

    public class RCTimelineEntities
    {
        public RCTimelineUrl url { get; set; }
        public RCTimelineDescription description { get; set; }
    }

    public class RCTimelineUrl
    {
        public Url1[] urls { get; set; }
    }

    public class Url1
    {
        public int start { get; set; }
        public int end { get; set; }
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
    }

    public class RCTimelineDescription
    {
        public RCTimelineMention[] mentions { get; set; }
        public Url2[] urls { get; set; }
        public RCTimelineHashtag[] hashtags { get; set; }
        public RCTimelineCashtag[] cashtags { get; set; }
    }

    public class RCTimelineMention
    {
        public int start { get; set; }
        public int end { get; set; }
        public string username { get; set; }
    }

    public class Url2
    {
        public int start { get; set; }
        public int end { get; set; }
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
    }

    public class RCTimelineHashtag
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class RCTimelineCashtag
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class RCTimelineTweet
    {
        public DateTime created_at { get; set; }
        public RCTimelineAttachments attachments { get; set; }
        public string[] edit_history_tweet_ids { get; set; }
        public string text { get; set; }
        public Context_Annotations[] context_annotations { get; set; }
        public string id { get; set; }
        public Public_Metrics1 public_metrics { get; set; }
        public Entities1 entities { get; set; }
        public string author_id { get; set; }
        public bool possibly_sensitive { get; set; }
        public string conversation_id { get; set; }
        public string reply_settings { get; set; }
        public string lang { get; set; }
        public Referenced_Tweets[] referenced_tweets { get; set; }
    }

    public class RCTimelineAttachments
    {
        public string[] media_keys { get; set; }
    }

    public class Public_Metrics1
    {
        public int retweet_count { get; set; }
        public int reply_count { get; set; }
        public int like_count { get; set; }
        public int quote_count { get; set; }
        public int bookmark_count { get; set; }
        public int impression_count { get; set; }
    }

    public class Entities1
    {
        public Url3[] urls { get; set; }
        public RCTimelineAnnotation[] annotations { get; set; }
        public Cashtag1[] cashtags { get; set; }
        public Hashtag1[] hashtags { get; set; }
    }

    public class Url3
    {
        public int start { get; set; }
        public int end { get; set; }
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public string media_key { get; set; }
    }

    public class RCTimelineAnnotation
    {
        public int start { get; set; }
        public int end { get; set; }
        public float probability { get; set; }
        public string type { get; set; }
        public string normalized_text { get; set; }
    }

    public class Cashtag1
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class Hashtag1
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class Context_Annotations
    {
        public RCTimelineDomain domain { get; set; }
        public RCTimelineEntity entity { get; set; }
    }

    public class RCTimelineDomain
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class RCTimelineEntity
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Referenced_Tweets
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class RCTimelineMeta
    {
        public string next_token { get; set; }
        public int result_count { get; set; }
        public string newest_id { get; set; }
        public string oldest_id { get; set; }
    }

    public class RCTimelineDatum
    {
        public Entities2 entities { get; set; }
        public DateTime created_at { get; set; }
        public Attachments1 attachments { get; set; }
        public string[] edit_history_tweet_ids { get; set; }
        public string text { get; set; }
        public Context_Annotations1[] context_annotations { get; set; }
        public string id { get; set; }
        public Public_Metrics2 public_metrics { get; set; }
        public Referenced_Tweets1[] referenced_tweets { get; set; }
        public string author_id { get; set; }
        public bool possibly_sensitive { get; set; }
        public string conversation_id { get; set; }
        public string reply_settings { get; set; }
        public string lang { get; set; }
    }

    public class Entities2
    {
        public Annotation1[] annotations { get; set; }
        public Mention1[] mentions { get; set; }
        public Url4[] urls { get; set; }
        public Cashtag2[] cashtags { get; set; }
        public Hashtag2[] hashtags { get; set; }
    }

    public class Annotation1
    {
        public int start { get; set; }
        public int end { get; set; }
        public float probability { get; set; }
        public string type { get; set; }
        public string normalized_text { get; set; }
    }

    public class Mention1
    {
        public int start { get; set; }
        public int end { get; set; }
        public string username { get; set; }
        public string id { get; set; }
    }

    public class Url4
    {
        public int start { get; set; }
        public int end { get; set; }
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public string media_key { get; set; }
        public RCTimelineImage[] images { get; set; }
        public int status { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string unwound_url { get; set; }
    }

    public class RCTimelineImage
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Cashtag2
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class Hashtag2
    {
        public int start { get; set; }
        public int end { get; set; }
        public string tag { get; set; }
    }

    public class Attachments1
    {
        public string[] media_keys { get; set; }
    }

    public class Public_Metrics2
    {
        public int retweet_count { get; set; }
        public int reply_count { get; set; }
        public int like_count { get; set; }
        public int quote_count { get; set; }
        public int bookmark_count { get; set; }
        public int impression_count { get; set; }
    }

    public class Context_Annotations1
    {
        public Domain1 domain { get; set; }
        public Entity1 entity { get; set; }
    }

    public class Domain1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Entity1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Referenced_Tweets1
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class RCTimelineError
    {
        public string value { get; set; }
        public string detail { get; set; }
        public string title { get; set; }
        public string resource_type { get; set; }
        public string parameter { get; set; }
        public string resource_id { get; set; }
        public string type { get; set; }
    }

}
