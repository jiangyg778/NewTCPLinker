using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPLinker.ORM
{
    [Table("ip_list")] // 映射到数据库表 dbo.ip_list
    public class IPList
    {
        [Key] // 主键
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 自增
        public int ID { get; set; }
        public string ProgramName { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string Remarks { get; set; }
    }
}
