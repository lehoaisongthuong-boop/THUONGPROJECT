//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THUONGPROJECT.Categories
//{
//    internal interface ICategoryAppService
//    {
//    }
//} 
using Abp.Application.Services;

 namespace THUONGPROJECT.Categories
{
        public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, int, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>
        {

        }
}


