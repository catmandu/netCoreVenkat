using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemotingService
{
    public interface IRemotingService
    {
        string GetMessage(string name);
    }
}
