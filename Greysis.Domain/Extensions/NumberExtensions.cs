using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greysis.Domain.Extensions
{
    public static class NumberExtensions
    {
        public static long ToAccountID(this long ID)
        {
            var txtID = "1";
            long result = ID;
            for (int i = 0; i < 12 - ID.ToString().Length; i++)
                txtID += "0";
            txtID += ID.ToString();
            long.TryParse(txtID, out result);
            return result;
        }
    }
}
