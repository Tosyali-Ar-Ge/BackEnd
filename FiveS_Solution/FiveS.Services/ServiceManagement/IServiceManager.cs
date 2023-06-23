using FiveS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Services.ServiceManagement
{
    public interface IServiceManager
    {
        IUserService User { get; }
    }
}
