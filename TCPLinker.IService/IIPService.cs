using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPLinker.ORM;

namespace TCPLinker.IService
{
    public interface IIPService
    {
        //GetIPList
        List<IPList> GetIPList();
        //Save
        IPList Save(IPList model);
    }
}
