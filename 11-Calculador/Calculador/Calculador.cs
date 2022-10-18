using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    class Calculador
    {

        // Operações
        public double SomarValores(double a, double b)
        {
            return a + b;
        }

        public double SubtrairValores(double a, double b)
        {
            return a - b;
        }

        public double MultiplicarValores(double a, double b)
        {
            return a * b;
        }

        public double DividirValores(double a, double b)
        {
            return a / b;
        }


        // Calculos das Áreas
        public int CalcularAreaQuadrado(int l)
        {
            return l * l;
        }

        public double CalcularAreaCirculo(double r)
        {
            double resultado = MultiplicarValores(Math.PI, MultiplicarValores(r, r));
            return resultado;
        }

        public int CalcularAreaTriangulo(int b, int h)
        {
            return (b * h) / 2;
        }

        public int CalcularAreaRetangulo(int b, int h)
        {
            return b * h;
        }

        // Par ou Impar
        public string ParOuImpar(int valor)
        {
            string resultado = string.Empty;

            if (valor % 2 == 0)
            {
                resultado = "Par";
            } else
            {
                resultado = "Impar";
            }

            return resultado;
        }

        // IMC
        public string CalcularImc(double peso, double altura) 
        {
            string resultado = string.Empty;

            //calculo 
            double imc = peso / (altura * altura);

            // verificação
            if (imc <= 18.5)
            {
                resultado = "Abaixo do Peso";
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                resultado = "Peso Normal";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                resultado = "Sobrepeso";
            }
            else if ((imc >= 30) && (imc < 40))
            {
                resultado = "Obesidade nível 1";
            }
            else if (imc >= 40)
            {
                resultado = "Obesidade Nível 2";
            }

            return resultado;
        }

    }
}
