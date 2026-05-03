//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THUONGPROJECT.Categories
//{
//    internal class CategoryDto
//    {
//    }
//}
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace THUONGPROJECT.Categories

{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : EntityDto<int>
    { public string Name { get; set; }
       public string Description { get; set; }
    }
}    