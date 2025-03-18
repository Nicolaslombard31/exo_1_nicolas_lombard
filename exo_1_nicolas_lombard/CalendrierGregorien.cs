using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_1_nicolas_lombard
{
    public class CalendrierGregorien
    {
        public static bool EstBissextile(ushort anneeBissextile)
        {
            return anneeBissextile % 4 == 0 && (anneeBissextile % 100 != 0 || anneeBissextile % 400 == 0);
        }
    }
}
