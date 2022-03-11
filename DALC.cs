using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectaztu
{
    public static class DALC
    {
        public static string GetConnectionString()
        {
            string constring = "Data Source=DESKTOP-KS3Q1A0\\SQLEXPRESS01; Initial Catalog=DBGR82; Integrated Security=true";
            return constring;
        }
    }
}
