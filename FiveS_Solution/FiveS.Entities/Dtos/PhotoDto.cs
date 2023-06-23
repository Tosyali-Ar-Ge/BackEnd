using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos

{
    public class PhotoDto : BaseDto
    {
        public string Detail { get; set; }
        public int DocumentType { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public int QuestionREF { get; set; }
        public int UserREF { get; set; }
        public int AuditREF { get; set; }
        public int FacilityREF { get; set; }
    }
}
