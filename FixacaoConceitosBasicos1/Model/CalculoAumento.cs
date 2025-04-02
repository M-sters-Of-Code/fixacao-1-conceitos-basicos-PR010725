using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculoAumento
    {
        public static double Calcular(double salario, double aumento){
            return salario + (salario * aumento/100);
        }
    }
}
