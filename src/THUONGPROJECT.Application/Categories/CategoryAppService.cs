using System.Linq;
using System.Linq.Dynamic.Core; 
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using THUONGPROJECT.Categories.Dto;

namespace THUONGPROJECT.Categories
{
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }

        // 1. TÍNH NĂNG TÌM KIẾM
        protected override IQueryable<Category> CreateFilteredQuery(PagedCategoryResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword),
                    x => x.Name.Contains(input.Keyword) || x.Description.Contains(input.Keyword));
        }

        // 2. TÍNH NĂNG SẮP XẾP
        protected override IQueryable<Category> ApplySorting(IQueryable<Category> query, PagedCategoryResultRequestDto input)
        {
           
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                return query.OrderBy(input.Sorting);
            }

            // không chọn gì, trả về sắp xếp mặc định
            return base.ApplySorting(query, input);
        }
    }
}