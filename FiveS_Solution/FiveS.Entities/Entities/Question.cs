using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Entities
{
    public class Question : BaseEntity
    {
        public int ControlArea { get; set; }
        public int Score { get; set; }
        public string Detail { get; set; }
        public int StepREF { get; set; }
        public int FacilityREF { get; set; }
    }
}
