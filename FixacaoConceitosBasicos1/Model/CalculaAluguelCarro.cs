using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometrageminicial, int quilometragemfinal){
            int diaria = 95;
            double precokm = 0.35;
            return (diaria * dias) + ((quilometragemfinal - quilometrageminicial) * precokm); 
        }
    }
}
