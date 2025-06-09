using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO.Variables
{
    public static class AppSettigs
    {

        public static bool IsProduction { get; set; }

        public static string DB_CONNECTION
        {
            get
            {
                if (IsProduction)
                    return "DbConnection";
                else
                    return "DbConnectionDev";
            }
        }
    }
}
