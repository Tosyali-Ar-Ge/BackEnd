using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Entities
{
    public class Audit : BaseEntity
    {
        public string Name { get; set; }
        public int Auditor { get; set; }
        public int ControlArea { get; set; }
        public DateTime FinishedDate { get; set; }
        public int Status { get; set; }
        public int Step { get; set; }
        public int TotalScore { get; set; }
        public int FacilityREF { get; set; }
    }
}
