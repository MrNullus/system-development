using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    interface ICalculador
    {

        /*
         * Operações básicas
        */

        /// <summary>
        /// Função para somar dois números
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>Retornara a soma de dois números</returns>
        double SomarValores(double a, double b);

        /// <summary>
        /// Função para subtrair dois números
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>Retornara a subtração de dois números</returns>
        double SubtrairValores(double a, double b);

        /// <summary>
        /// Função para multiplicar dois números
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>Retornara a multiplicação de dois números</returns>
        double MultiplicarValores(double a, double b);

        /// <summary>
        /// Função para dividir dois números
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>Retornara a divisão de dois números</returns>
        double DividirValores(double a, double b);



        /* 
         * Calculos das Áreas 
        */
        /// <summary>
        /// Função para calcular a área de um quadrado
        /// </summary>
        /// <param name="lado">Número de um lado do quadrado</param>
        /// <returns>Retornara a área de um quadrado</returns>
        int CalcularAreaQuadrado(int lado);

        /// <summary>
        /// Função para calcular a área de um círculo
        /// </summary>
        /// <param name="r">Número do raio do círculo</param>
        /// <returns>Retornara a área de um círculo</returns>
        double CalcularAreaCirculo(double r);

        /// <summary>
        /// Função para calcular a área de um triângulo
        /// </summary>
        /// <param name="b">Valor da base do triângulo</param>
        /// <param name="h">Valor da altura do triângulo</param>
        /// <returns>Retornara a área de um triângulo</returns>
        int CalcularAreaTriangulo(int b, int h);

        /// <summary>
        /// Função para calcular a área de um retângulo
        /// </summary>
        /// <param name="b">Valor da base do retângulo</param>
        /// <param name="h">Valor da altura do retângulo</param>
        /// <returns>Retornara a área de um retângulo</returns>
        int CalcularAreaRetangulo(int b, int h);


        /*
         * Par ou Impar
        */
        /// <summary>
        /// Função para verificar se um número é par ou impar
        /// </summary>
        /// <param name="valor">Número inteiro que será verificado</param>
        /// <returns></returns>
        string ParOuImpar(int valor);


        /*
         * IMC
        */

        /// <summary>
        /// Função para calcular o IMC, deve-se informar um peso e uma altura
        /// </summary>
        /// <param name="peso">Valor do peso</param>
        /// <param name="altura">Valor da altura</param>
        /// <returns></returns>
        string CalcularImc(double peso, double altura);

    }
}
