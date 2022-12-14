using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningEFCore.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }



        public List<Product> Products { get; set; }
    }

    //[Table("CategoryProducts")]
    //public class CategoryProduct
    //{
    //    [Key]
    //    public Guid CategoryId { get; set; }
    //    [Key]
    //    public Guid ProductId { get; set; }
        
    //    [StringLength(50)]
    //    public string? Note { get; set; }

    //    public Category Category { get; set; }
    //    public Product Product { get; set; }
    //}
}
