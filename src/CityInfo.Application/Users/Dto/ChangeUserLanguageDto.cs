using System.ComponentModel.DataAnnotations;

namespace CityInfo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}