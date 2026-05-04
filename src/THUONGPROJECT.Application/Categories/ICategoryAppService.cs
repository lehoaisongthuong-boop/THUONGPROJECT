using Abp.Application.Services;
using THUONGPROJECT.Categories.Dto; // Gọi thư mục Dto vào

namespace THUONGPROJECT.Categories
{
   
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, int, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>
    {
    }
}