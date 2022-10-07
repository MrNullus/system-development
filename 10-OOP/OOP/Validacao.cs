using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Validacao
    {
        Funcoes func = new Funcoes();

        /// <summary>
        /// Função serve para verificar se o campo digitado possui valor ou não possui valor
        /// </summary>
        /// <param name="campo">Campo a ser verificado</param>
        /// <returns></returns>
        public bool IsVazio(string campo)
        {
            if (campo == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Função verifica se valor informado é númerico
        /// </summary>
        /// <param name="campo">Campo a ser verificado</param>
        /// <returns></returns>
        public bool IsValorNumerico(string campo)
        {
            try
            {
                double num = Convert.ToDouble(campo);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        /// <summary>
        /// Função para verificar se determinado campo informado possui um determinado tamanho
        /// </summary>
        /// <param name="campo">Campo a ser verificado</param>
        /// <param name="tamanho">Tamanho exato que o campo deverá ter</param>
        /// <returns></returns>
        public bool TamanhoCampoRequerido(string campo, int tamanho)
        {
            if (campo.Length == tamanho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Função efetua validação de CPF
        /// </summary>
        /// <param name="cpf">CPF informado</param>
        /// <returns></returns>
        public bool ValidarCpf(string cpf)
        {
            if (!IsVazio(cpf))
            {
                return false;
            }

            if (!IsValorNumerico(cpf))
            {
                return false;
            }

            if (!TamanhoCampoRequerido(cpf, 11))
            {
                return false;
            }
            
            // dados iniciais
            List<int> onzeDigitos = new List<int>();
            List<int> noveDigitos = new List<int>();
            string ultimos2Digitos = string.Empty;

            string cpfDigitado = cpf;  

            // pegar os nove digitos do cpf digitado
            for (int posicao = 0; posicao < cpfDigitado.Length; posicao++)
            {
                string carac = cpfDigitado.Substring(posicao, 1);

                if (int.TryParse(carac, out int digito))
                {
                    onzeDigitos.Add(digito);

                    if (posicao <= 8)
                    {
                        noveDigitos.Add(digito);
                    }
                    else
                    {
                        ultimos2Digitos += digito.ToString();
                    }
                }
            }

            // verificações secundarias - (se possui apenas numeros e se é valido)
            if (func.temDigitosIguais(onzeDigitos))
            {
                return false;
            }

            // digito 10 e 11 calculados
            int digito10 = func.calcDigito10(noveDigitos);
            int digito11 = func.calcDigito11(noveDigitos, digito10);

            // tornando os digitos 10 e 11 (inseridos e calculados) em um unico texto 
            string ultimosDigitos = ultimos2Digitos[0].ToString() + ultimos2Digitos[1].ToString();
            string ultimosDigiCalculados = digito10.ToString() + digito11.ToString();

            // verificar se esses digitos são correspondentes
            bool cpfValido = func.validarDoisUltimosDigitos(ultimos2Digitos, ultimosDigiCalculados);

            // autenticação final - verificar se é ou não valido
            if (!cpfValido)
            {
                return false;
            }

            return true;
        }
    }
}
