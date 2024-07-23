using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ILocationStatus
    {
         bool IsRemote { get; set; }
         bool IsOnsite { get; set; }
    }
}
