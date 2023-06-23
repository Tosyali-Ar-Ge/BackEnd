using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos
{
    public class UserDto : BaseDto
    {
        public int Value { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int Type { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public int ControlAreaREF { get; set; }
        public int FacilityREF { get; set; }
    }
}
