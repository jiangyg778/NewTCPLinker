using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPLinker.Base.Utils
{
    public static class StringExtension
    {
        public static string FormatStringLog(this String msg)
        {

            return "[" + DateTime.Now + "]" + Environment.NewLine + msg + Environment.NewLine + Environment.NewLine;

        }
    }
}
