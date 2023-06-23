using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos
{
    public class ControlAreaDto : BaseDto
    {
        public string Name { get; set; }
        public int FirstAuditorREF { get; set; }
        public int SubsAuditorREF { get; set; }
        public int StepREF { get; set; }
        public int FacilityREF { get; set; }
    }
}
