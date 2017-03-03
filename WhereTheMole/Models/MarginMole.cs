using Catel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTheMole.Models
{
    class MoleRandom : ModelBase
    {

        public static String[] margins = new String[]
        {
            "50, 65",
            "50, 290",
            "50, 520",
            "590, 520",
            "320, 65",
            "590, 65",
            "320, 290",
            "590, 290",
            "320, 520"
        };

        public static string GetRandomMargin()
        {
            return margins[new Random().Next(margins.Length)];
        }
 
   

    }
}
