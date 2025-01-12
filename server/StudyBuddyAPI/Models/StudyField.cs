using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a study field in the system.
    /// </summary>
    public class StudyField
    {
        /// <summary>
        /// Unique identifier for the study field.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the study field.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The collection of user study fields associated with this study field.
        /// </summary>
        public ICollection<UserStudyField> UserStudyFields { get; set; } = new List<UserStudyField>();
    }
}
