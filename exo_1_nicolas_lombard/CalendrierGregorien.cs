using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_1_nicolas_lombard
{
    public class CalendrierGregorien
    {
        public static bool EstBissextile(int anneeBissextile)
        {
            return anneeBissextile % 400 == 0;
        }
        
        public static bool NestPasBissextile(int anneeNonBissextile)
        {
            return anneeNonBissextile % 100 == 0 && anneeNonBissextile % 400 != 0;
        }
    }
}
