using FiveS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Dtos
{
    public class AnswerDto : BaseDto
    {
        public int Score { get; set; }
        public bool ResponseIsYes { get; set; }
        public int QuestionREF { get; set; }
    }
}
