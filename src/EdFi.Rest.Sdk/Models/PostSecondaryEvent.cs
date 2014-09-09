using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.Rest.Models {
  public class PostSecondaryEvent {
    /* The unique identifier of the resource. */
    public string id { get; set; }

    /* A reference to the related Student resource. */
    public StudentReference studentReference { get; set; }

    /* The postsecondary event that is logged (e.g., FAFSA application, college application, college acceptance)   */
    public string categoryType { get; set; }

    /* The date the event occurred or was recorded.   */
    public DateTime? eventDate { get; set; }

    /* This entity captures significant postsecondary events during a student's high school tenure (e.g., FAFSA application or college application, acceptance and enrollment). */
    public PostSecondaryEventPostSecondaryInstitution postSecondaryInstitution { get; set; }

    /* A unique system-generated value that identifies the version of the resource. */
    public string _etag { get; set; }

    }
}
