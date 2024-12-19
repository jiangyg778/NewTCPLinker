using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPLinker.ORM
{
  public  class TCPLinkerDbContext:DbContext
    {
        public TCPLinkerDbContext(DbContextOptions<TCPLinkerDbContext> options) : base(options)
        {
        }
        //配置数据库链接
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TCPLinkerDb;;Integrated Security=True;Trust Server Certificate=True").LogTo(Console.WriteLine, LogLevel.Information); // 输出到控制台
                try
                {
                    using (var connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TCPLinkerDb;;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        connection.Open();
                        System.Diagnostics.Debug.WriteLine("数据库连接成功！");
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    // 弹出错误提示框
                    System.Windows.MessageBox.Show(
                        "数据库连接失败：" + ex.Message,
                        "错误",
                        System.Windows.MessageBoxButton.OK,
                        System.Windows.MessageBoxImage.Error
                    );
                    //错误框提示
                    System.Diagnostics.Debug.WriteLine("数据库连接失败：" + ex.Message);
                }

            }
        }
        //映射到数据库表
        public DbSet<IPList> IPList { get; set; }
    }
}
