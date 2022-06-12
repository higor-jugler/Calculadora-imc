using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMCInfo people = new IMCInfo();
            people.checkIMC();
            //Console.WriteLine(iMCDatas.IMC);
        }
    }
}
