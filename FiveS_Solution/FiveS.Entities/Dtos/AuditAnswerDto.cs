﻿using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos
{
    public class AuditAnswerDto : BaseDto
    {
        public string Answer { get; set; }
        public int Score { get; set; }
        public int AuditREF { get; set; }
        public int QuestionREF { get; set; }
    }
}
