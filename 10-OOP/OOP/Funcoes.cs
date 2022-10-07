using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Funcoes
    {
        /// <summary>
        /// Função que irá eftuar o calculo dos digitos (a multiplicação deles e a soma, retornando seu resto)
        /// </summary>
        /// <param name="noveDigitos">Será os nove digitos do CPF</param>
        /// <param name="digInicio">Número inteiro que vai definir até que númnero ele irá fazer a soma e a multiplicação para o calculo do CPF</param>
        /// <returns></returns>
        public int calcDigitos(List<int> noveDigitos, int digInicio)
        {
            int soma = 0, mult = 0;

            for (int i = digInicio, d = 0; i >= 2; i--, d++)
            {
                int digito = noveDigitos[d];

                mult = digito * i;
                soma += mult;
            }

            return (soma % 11);
        }


        /// <summary>
        /// Função para obter um digito, a partir das condições e calculos do resto (se resto menor que 2: digito igual a 0, senão: será resto menos 11)
        /// </summary>
        /// <param name="resto">Resto do calculo feito entre os 9 ou 10 digitos que deverão ser feito</param>
        /// <returns>Retorna o resto da divisão inteira por 11</returns>
        public int obterDigito(int resto)
        {
            if (resto < 2)
            {
                return 0;
            }
            else
            {
                return (resto - 11);
            }
        }


        /// <summary>
        /// Funçãs para o calculo do digito 10
        /// </summary>
        /// <param name="noveDigitos">Todos os nove digitos do CPF</param>
        /// <returns>O digito 10</returns>
        public int calcDigito10(List<int> noveDigitos)
        {
            int digito10 = 0, resto = 0;

            resto = calcDigitos(noveDigitos, 10);
            digito10 = Math.Abs(obterDigito(resto));

            return (digito10);
        }


        /// <summary>
        /// Funçãs para o calculo do digito 11
        /// </summary>
        /// <param name="noveDigitos">Todos os nove digitos do CPF</param>
        /// <param name="digito10">Será o digito 10, do CPF</param>
        /// <returns>O digito 11</returns>
        public int calcDigito11(List<int> noveDigitos, int digito10)
        {
            int digito11 = 0, resto = 0;
            noveDigitos.Add(digito10);

            resto = calcDigitos(noveDigitos, 11);
            digito11 = Math.Abs(obterDigito(resto));

            return (digito11);
        }


        /// <summary>
        /// Função que irá validar se os dois ultimos digitos calculados são iguais aos ultimos digitos do CPF informado
        /// </summary>
        /// <param name="ultimos2Digitos">Dois ultimos digitos informados</param>
        /// <param name="ultimosDigitosCalculados">Dois ultimos digitos que foram calculados</param>
        /// <returns>Retorna true, se os digitos são iguais. Senão, retornara false</returns>
        public bool validarDoisUltimosDigitos(string ultimos2Digitos, string ultimosDigitosCalculados)
        {
            if (ultimos2Digitos == ultimosDigitosCalculados)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Função para validar se os digitos do CPF informado são iguais
        /// </summary>
        /// <param name="cpf">CPF informado</param>
        /// <returns>Se forem iguais, retorna true. Senão, false</returns>
        public bool temDigitosIguais(List<int> cpf)
        {
            int qtdeDigitosIguais = 0;
            int aux = 0;
            for (int d = 1; d <= 10; d++)
            {
                if (cpf[aux] == cpf[d])
                {
                    qtdeDigitosIguais++;
                }
            }

            if (qtdeDigitosIguais >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
