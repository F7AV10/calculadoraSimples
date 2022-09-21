using System;
using System.ComponentModel;
///using System.Globalization; INCLUIR APENAS SE FOR USAR "." AO INVES DE ","
using System.Text;
using System.Windows.Forms;

//////////////////////////////////////////////////////////////////////////////////////////
// EXERCICIO FEITO POR FLÁVIO NEVES - GITHUB https://github.com/F7AV10                  ///
// UMA CALCULADORA SIMPLES FEITA EM C# E WINFORMS, TESTANDO CONHECIMENTOS ADQUIRIDOS    ///
// COM O EXERCICIO DO PONG - https://github.com/F7AV10/pingPong                         ///
//////////////////////////////////////////////////////////////////////////////////////////

namespace calculadoraSimples
{
    public partial class calculadoraSimples : Form
    {
        decimal valor1 = 0, valor2 = 0, porcent = 0;
        string operacao = "";
        

        public calculadoraSimples()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //AO CLICAR CADA UM DOS BOTOES ABAIXO, O VALOR DA SUA TECLA E ADICIONADA A CAIXA DE TEXTO textResultado
        private void botao0_Click(object sender, EventArgs e)
        {
            //ESSE IF EM CADA BOTÃO VERIFICA SE O NUMERO DE CARACTERES NA CAIXA DE TEXTO textoResultado NÃO PASSA DE 16
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "0";
            }
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "1";
            }
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "2";
            }
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "3";
            }
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "4";
            }
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "5";
            }
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "6";
            }
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "7";
            }
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "8";
            }
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            if (textResultado.TextLength < 16)
            {
                textResultado.Text += "9";
            }
        }

        private void botaoVirgula_Click(object sender, EventArgs e)
        {
            textResultado.Text += ",";
        }
        //AQUI INICIA OS BOTOES DE OPERACAO, SOMA, MULTIPLICAÇÃO, DIVISÃO, SUBTRAÇÃO E PORCENTAGEM
        //BOTÃO DE "="
        private void botaoIgual_Click(object sender, EventArgs e)
        {
            //VERIFICA SE A CAIXA DE TEXTO NÃO ESTÁ VAZIA
            if (textResultado.Text != "")
            {
                //VERIFICA SE A VARIAVEL operacao NÃO ESTÁ VAZIA
                if (operacao != "")
                {
                    //COM O decimal.Parse() A VARIAVEL E CONVERTIDA 
                    valor2 = decimal.Parse(textResultado.Text);
                    labelValor1.Text = "";
                }
            }
            //VERIFICA QUAL O VALOR DA VARIAVEL OPERACAO (SOMA,MULT,DIV,SUB ou PORC)
            if (operacao == "SOMA")
            {
                //ATRIBUI AO textResultado O TEXTO DO RESULTADO DA OPERAÇÃO, ANTES CONVERTENDO OS VALORES EM TEXTO COM Convert.ToString()
                textResultado.Text = Convert.ToString( valor1 + valor2 );
                //ZERA O VALOR DA VARIAVEL OPERACAO E DAS LABELS, PREPARANDO PARA PROXIMA ENTRADA DE VALORES OU OPERACAO
                operacao = "";
                labelOperacao.Text = "";
                labelValor1.Text = "";
            }
            else if (operacao == "SUB")
            {
                
                textResultado.Text = Convert.ToString(valor1 - valor2);
                operacao = "";
                labelOperacao.Text = "";
                labelValor1.Text = "";
            }
            else if (operacao == "MULT")
            {
                
                textResultado.Text = Convert.ToString(valor1 * valor2);
                operacao = "";
                labelOperacao.Text = "";
                labelValor1.Text = "";
            }
            else if (operacao == "DIV")
            {
                
                textResultado.Text = Convert.ToString(valor1 / valor2);
                operacao = "";
                labelOperacao.Text = "";
                labelValor1.Text = "";
            }
            
            else 
            {
                
                textResultado.Text = textResultado.Text;
                operacao = "";
                labelOperacao.Text = "";
                labelValor1.Text = "";
            }

        }

        private void botaoSub_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                //COM O decimal.Parse() A VARIAVEL E CONVERTIDA. O PARAMETRO CultureInfo.InvariantCulture PODE SER USADO PARA ACRESCENTAR O "." CASO NÃO DEFINA O BOTÃO COMO VIRGULA
                valor1 = decimal.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "SUB";
                labelOperacao.Text = "-";
                labelValor1.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("A operação não pode ser feita sem um valor inicial!");
            }
            
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                //COM O decimal.Parse() A VARIAVEL E CONVERTIDA
                valor1 = decimal.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "DIV";
                labelOperacao.Text = "/";
                labelValor1.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("A operação não pode ser feita sem um valor inicial!");
            }
        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                //COM O decimal.Parse() A VARIAVEL E CONVERTIDA
                valor1 = decimal.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "MULT";
                labelOperacao.Text = "*";
                labelValor1.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("A operação não pode ser feita sem um valor inicial!");
            }
            
        }
        private void botaoSoma_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                //COM O decimal.Parse() A VARIAVEL E CONVERTIDA
                valor1 = decimal.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
                labelValor1.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("A operação não pode ser feita sem um valor inicial!");
            }

        }
        //BOTÃO CE APAGA APENAS O TEXTO ATRIBUIDO AO textResultado NO MOMENTO
        private void botaoCE_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }
        //PERMITIR APENAS NUMEROS DIGITADOS PELO TECLADO NO TEXT bOX textResultado
        private void textResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //APAGA TODAS AS VARIAVEIS, "RESET"
        private void botaoC_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            labelOperacao.Text = "";
            labelValor1.Text = "";
        }
        //BOTÃO DE PORCENTAGEM, QUE JA FAZ A OPERAÇÃO E ARMAZENA O VALOR NA VARIAVEL porcent PARA SER EXIBIDO PARA O USUARIO NA MESMA HORA
        private void botaoPorc_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "" && valor1 != 0)
            {
                porcent = ((decimal.Parse(textResultado.Text)) * valor1)/100;
                textResultado.Text = Convert.ToString(porcent);
            }
            else
            {
                MessageBox.Show("A operação não pode ser feita sem um valor inicial!");
            }
        }

    }
}
