//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THUONGPROJECT.Categories
//{
//    internal class PagedCategoryResultRequestDto
//    {
//    }
////}
 using Abp.Application.Services.Dto;
 namespace THUONGPROJECT.Categories
{
    public class PagedCategoryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; } // để lưu trữ từ khóa tìm kiếm, có thể được sử dụng để lọc danh sách các danh mục dựa trên tên hoặc mô tả của chúng
    }
}