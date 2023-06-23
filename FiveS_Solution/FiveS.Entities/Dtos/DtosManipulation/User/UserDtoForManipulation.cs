using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Domain.Dtos.DtosManipulation.User
{
    public abstract record UserDtoForManipulation
    {
        [Required(ErrorMessage = "Title is required field.")]
        public int Value { get; init; }

        [Required(ErrorMessage = "Email is required field.")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Name is required field.")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Password is required field.")]
        public string Password { get; init; }

        [Required(ErrorMessage = "Role is required field.")]
        public int Role { get; init; }

        [Required(ErrorMessage = "Type is required field.")]
        public int Type { get; init; }

        [Required(ErrorMessage = "CompanyRegistrationNumber is required field.")]
        public string CompanyRegistrationNumber { get; init; }

        [Required(ErrorMessage = "Surname is required field.")]
        public string Surname { get; init; }

        [Required(ErrorMessage = "UserName is required field.")]
        public string UserName { get; init; }

        [Required(ErrorMessage = "ControlAreaREF is required field.")]
        public int ControlAreaREF { get; init; }

        [Required(ErrorMessage = "FacilityREF is required field.")]
        public int FacilityREF { get; init; }
    }
}
