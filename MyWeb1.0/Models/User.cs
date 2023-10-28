using System.ComponentModel.DataAnnotations;

namespace MyWeb1._0.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name="Введите имя: ")]
        [MinLength(2,ErrorMessage ="Минимальная длинна должна быть больше 2 символов")]
        [MaxLength(15, ErrorMessage = "Длинна не должна превышать 15 символов")]
        [Required(ErrorMessage ="Вам нужно ввести имя")]
        
        public string? Name { get; set; }

        [Display(Name = "Введите фамилию: ")]
        [MinLength(2, ErrorMessage = "Минимальная длинна должна быть больше 2 символов")]
        [MaxLength(15, ErrorMessage = "Длинна не должна превышать 15 символов")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string? Surname { get; set; }

        [Display(Name = "Введите возраст: ")]
        [Range(1,110,ErrorMessage ="Недопустимый возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту: ")]
        [EmailAddress]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string? Email { get; set; }
    }
}
