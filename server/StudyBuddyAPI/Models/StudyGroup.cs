namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a study group in the system.
    /// </summary>
    public class StudyGroup
    {
        /// <summary>
        /// Unique identifier for the study group.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the study group.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// A brief description of the study group.
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// Identifier for the study field associated with the group.
        /// </summary>
        public int StudyFieldId { get; set; }

        /// <summary>
        /// The study field associated with this group.
        /// </summary>
        public required StudyField StudyField { get; set; }

        /// <summary>
        /// The collection of users who are members of the study group.
        /// </summary>
        public ICollection<User> Members { get; set; } = new List<User>();
    }
}
