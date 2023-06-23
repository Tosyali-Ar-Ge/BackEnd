using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FiveS.Entities.LogModel
{
    public class LogDetails
    {
        public object? ModelName { get; set; }
        public object? Controller { get; set; }
        public object? Action { get; set; }
        public object? Id { get; set; }
        public object? CreateDatetime { get; set; }

        public LogDetails()
        {
            CreateDatetime = DateTime.Now;
        }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
