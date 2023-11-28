using System;

namespace SocialOpinionAPI.DTO.Timeline
{

    public class UserReverseChronologicalTimelineModel
    {
        public RCTimelineDatum[] data { get; set; }
        public RCTimelineIncludes includes { get; set; }
        public RCTimelineError[] errors { get; set; }
        public RCTimelineMeta meta { get; set; }
    }
}
