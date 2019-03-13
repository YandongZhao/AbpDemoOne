using System.ComponentModel.DataAnnotations;

namespace AbpDemoOne.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}