using Abp.Application.Services.Dto;

namespace THUONGPROJECT.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

