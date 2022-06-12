using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class IMCDatas
    {
        // Propriedades
        public double IMC { get; set; }

        public string masculine;
        public string female;

        public double weight;
        public double height;

        // Métodos

        public void checkIMC()
        {
            Console.WriteLine("Escolha seu gênero: ");
            Console.WriteLine("\tm - Masculino");
            Console.WriteLine("\tf - Femenino");

            switch (Console.ReadLine())
            {
                case "m":
                    masculine = "m";
                    try
                    {
                        calcIMC();
                        if (this.IMC < 20.7)
                        {
                            Console.WriteLine("Abaixo do peso.");
                        }
                        else if (this.IMC == 20.7 || this.IMC <= 26.4)
                        {
                            Console.WriteLine("No peso normal.");
                        }
                        else if (this.IMC == 26.4 || this.IMC <= 27.8)
                        {
                            Console.WriteLine("Marginalmente acima do peso");
                        }
                        else if (this.IMC == 27.8 || this.IMC <= 32.3)
                        {
                            Console.WriteLine("Acima do peso ideal.");
                        }
                        else
                        {
                            Console.WriteLine("Obeso");
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                    break;

                case "f":
                    female = "f";
                    try
                    {
                        calcIMC();
                        if (this.IMC < 19.1)
                        {
                            Console.WriteLine("Abaixo do peso.");
                        }
                        else if (this.IMC == 19.1 || this.IMC <= 25.8)
                        {
                            Console.WriteLine("No peso normal.");
                        }
                        else if (this.IMC == 25.8 || this.IMC <= 27.3)
                        {
                            Console.WriteLine("Marginalmente acima do peso");
                        }
                        else if (this.IMC == 27.3 || this.IMC <= 31.1)
                        {
                            Console.WriteLine("Acima do peso ideal.");
                        }
                        else
                        {
                            Console.WriteLine("Obeso");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    break;

                default:
                    break;
            }

        }

        public double calcIMC()
        {
            // ATENÇÃO O '.' OU ',' VAI DO SISTEMA OPERACIONAL
            Console.WriteLine("Digite seu peso: ** use ',' em vez de '.'**");
            weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(weight);
            Console.WriteLine("Digite sua altura: ** use ',' em vez de '.'**");
            height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(height);

            IMC = (weight / (height * height));
            Console.WriteLine("\nIMC: " + IMC);
            return IMC;

        }
    }
}
