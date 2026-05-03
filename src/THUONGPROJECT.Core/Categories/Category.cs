//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THUONGPROJECT.Categories
//{
//    internal class Category
//    {
//    }
//}

using Abp.Domain.Entities.Auditing; // gọi thư viện lõi của ASP.NET Boilerpalte (ABP) để sử dụng class định nghĩa cho tên danh mục và mô tả
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THUONGPROJECT.Categories
{
    [Table("AppCategories")] // để Entity Framework sẽ tạo tên bảng trong cơ sở dữ liệu là "AppCategories" thay vì "Categories"
    public class Category : FullAuditedEntity<int> // tự động cho Id là khóa chín với kiểu dữ liệu và int nếu 
    {
        [Required] // những yêu cầu bắt buộc, không được null
        [StringLength(255)]
        public string Name { get; set; } // get: cho phép đọc  - set: cho phép gán/ thêm giá trị mới vào

        [StringLength(1000)]
        public string Description { get; set; }
    }
}

