using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Entities

{
    public class Token : BaseEntity
    {
        public int TokenID { get; set; }
        public string TokenValue { get; set; }
        public int UserREF { get; set; }
    }
}
