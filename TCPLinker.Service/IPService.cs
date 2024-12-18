using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPLinker.IService;
using TCPLinker.ORM;

namespace TCPLinker.Service
{
    public class IPService : BaseService, IIPService

    {
        public IPService(DbContext context) : base(context)
        {

        }

        public List<IPList> GetIPList()
        {
          return this.Query<IPList>(x => x.ID > 0).ToList();
        }

        //保存
        public IPList Save(IPList model)
        {
            return this.Insert<IPList>(model);
        }
    }
}
