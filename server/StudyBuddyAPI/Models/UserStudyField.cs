using System.ComponentModel.DataAnnotations.Schema;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents the relationship between a user and a study field.
    /// </summary>
    public class UserStudyField
    {
        /// <summary>
        /// The email of the user associated with the study field.
        /// </summary>
        [ForeignKey("User")]
        public string UserEmail { get; set; } = null!;

        /// <summary>
        /// The user associated with this study field.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// The unique identifier of the study field.
        /// </summary>
        [ForeignKey("StudyField")]
        public int StudyFieldId { get; set; }

        /// <summary>
        /// The study field associated with the user.
        /// </summary>
        public StudyField StudyField { get; set; } = null!;
    }
}
