using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos
{
    public class TokenDto : BaseDto
    {
        public int TokenID { get; set; }
        public string TokenValue { get; set; }
        public int UserREF { get; set; }
    }
}
