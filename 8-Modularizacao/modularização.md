- Abstração
Parte de uma solução de um problema

- Modularização

Criar rotinas que vão reutilizar codigo, ajuda na manutenção de código

- Funções
Executa e retorna um valor

public tipo_retorno nome(tipo_param nome_param)  {
    // codigo...
    // assim que retornar ele encerra o processo
    return algum_retorno;
}

- Procedimento
Executa e não retorna nada (void)

public void nome(tipo args) {
    // codigo...
}

-=================
// A função retorna texto de dois valores inteiros informados
        public string SomarNumeros(string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);

            return (valor1 + valor2).ToString();
        }


        // Criando Procedimento - esse procedimento vai limpar os controles
        /*
        public void LimparControles()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Text = string.Empty;
                }

                if (item == lblMensagem)
                {
                    lblMensagem.Text = string.Empty;
                }
            }

        } 