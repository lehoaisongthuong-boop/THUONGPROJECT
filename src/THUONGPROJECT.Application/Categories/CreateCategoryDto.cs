using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
 namespace THUONGPROJECT.Categories
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]        
        public string Description { get; set; }
    }
}