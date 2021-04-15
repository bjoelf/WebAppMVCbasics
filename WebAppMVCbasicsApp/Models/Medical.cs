using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCbasicsApp.Models
{
    public class Medical
    {
        public static string FeverTest(float temperature)
        {
            //decimal dTemp = new decimal();
            // dTemp = Convert.ToDecimal(temperature);
            return (temperature > 37) ? "You have fever" : "You don't have any fever";
        }
    }
}
