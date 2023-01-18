using AutoSchool.Domain.Enum;

namespace AutoSchool.Domain.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
       
    }


}