using FiveS.Entities.Exceptions.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveS.Entities.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(int id) : base($"The user id :  {id} not found.")
        {
        }
    }
}
