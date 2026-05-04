using Abp.Application.Services;
using THUONGPROJECT.Categories.Dto; // Gọi thư mục Dto vào

namespace THUONGPROJECT.Categories
{
    // Cập nhật lại tên PagedCategoryResultRequestDto cho khớp với class
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, int, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>
    {
    }
}