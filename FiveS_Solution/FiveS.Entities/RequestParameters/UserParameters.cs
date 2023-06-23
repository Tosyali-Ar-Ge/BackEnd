using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FiveS.Entities.RequestParameters
{
    public class UserParameters : RequestParameters
    {
        public String? SearchTerm { get; set; }

        public UserParameters()
        {
            OrderBy = "id";
        }
    }
}
