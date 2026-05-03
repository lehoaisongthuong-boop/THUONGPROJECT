//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THUONGPROJECT.Categories
//{
//    internal class CategoryAppService
//    {
//    }
//}

using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace THUONGPROJECT.Categories
{
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
    }
}