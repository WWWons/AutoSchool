using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoSchool.Domain.ViewModels.User
{
    
    public class UserViewModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Укажите роль")]
        [Display(Name = "Роль")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Укажите логин")]
        [Display(Name = "Логин")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}

