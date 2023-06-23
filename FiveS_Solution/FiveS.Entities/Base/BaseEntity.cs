using FiveS.Entities.Base.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Base
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDatetime { get; set; }
    }
}
