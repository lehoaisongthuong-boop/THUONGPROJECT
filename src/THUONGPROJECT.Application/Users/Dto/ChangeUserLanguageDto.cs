using System.ComponentModel.DataAnnotations;

namespace THUONGPROJECT.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}