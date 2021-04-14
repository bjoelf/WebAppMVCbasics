using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCbasicsApp.Models
{
    public class Medical
    {
        public static string FeverTest(string temperature)
        {
            decimal dTemp = new decimal();
            dTemp = Convert.ToDecimal(temperature);
            return (dTemp > 37) ? "You have fever" : "You don't have any fever";
        }
    }
}
