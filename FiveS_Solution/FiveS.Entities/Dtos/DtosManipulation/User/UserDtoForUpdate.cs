﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Domain.Dtos.DtosManipulation.User
{
    public record UserDtoForUpdate : UserDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}