using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enum
{
    public enum Role
    {
        [Display(Name = "Ученик")]
        Student = 0,
        [Display(Name = "Учитель")]
        Teacher = 1,
        [Display(Name = "Админ")]
        Admin = 2,
    }
}