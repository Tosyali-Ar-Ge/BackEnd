using FiveS.Entities.Base.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Base
{
    public class BaseDto : IDto
    {
        public int Id { get; set; }
    }
}
