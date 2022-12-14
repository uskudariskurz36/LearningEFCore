using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningEFCore.Entities
{
    [Table("BlogPosts")]
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        
        [Column("blogpost_title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        // ForeignKey Column
        public int UserId { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
