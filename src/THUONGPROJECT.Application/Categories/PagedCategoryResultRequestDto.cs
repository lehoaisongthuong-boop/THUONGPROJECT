using Abp.Application.Services.Dto;

namespace THUONGPROJECT.Categories.Dto
{
    // Kế thừa đúng PagedAndSortedResultRequestDto để có tính năng Sắp xếp
    public class PagedCategoryResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}