using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       double valor1 = 0; 
       double valor2 = 0;
       double resposta = 0;
       string operacao = " ";
       string valorb = " ";
        string lbl = " ";















        //caixa de resposta
        private void Caixa_resposta_TextChanged(object sender, EventArgs e)
        {
            

        }




        // numero 0
        private void button19_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "0";
        }

        // numero 1
        private void button20_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "1";
        }

        // numero 2
        private void button8_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "2";
        }

        // numero 3
        private void button6_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "3";
        }

        // numero 4
        private void button21_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "4";
        }

        // numero 5
        private void button13_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "5";
        }

        // numero 6
        private void button9_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "6";
        }

        // numero 7
        private void button22_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "7";
        }

        // numero 8
        private void button14_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "8";
        }

        // numero 9
        private void button12_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "9";
        }





        // botão divisão
        private void button16_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "/";
            operacao = "/";
            valorb = Caixa_resposta.Text;
            lbl = valor1 + " /";
            valor1 = double.Parse(Caixa_resposta.Text);
        }

        // botão multiplicação
        private void button11_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "x";
            operacao = "x";
            valorb = Caixa_resposta.Text;
            lbl = valor1 + " x";
            valor1 = double.Parse(Caixa_resposta.Text);
        }

        // botão subtração
        private void button4_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "-";
            
            operacao = "-";
            valorb = Caixa_resposta.Text;
            lbl = valor1 + " -";
            valor1 = double.Parse(Caixa_resposta.Text);
        }

        // botão adição
        private void button3_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += "+";
            
            
            operacao = "+";
            valorb = Caixa_resposta.Text;
            lbl = valor1 + " +";
            valor1 = double.Parse(Caixa_resposta.Text);
        }

        // botão Virgula
        private void button7_Click(object sender, EventArgs e)
        {
            Caixa_resposta.Text += ",";
        }

        // botão Apagar
        private void button5_Click_1(object sender, EventArgs e)
        {
            Caixa_resposta.Text = "";
                
        }

        // botão porcentagem
        private void button17_Click(object sender, EventArgs e)
        {

        }

        // botão igual
        private void button2_Click(object sender, EventArgs e)
        {

            Caixa_resposta.Text += "";

        }

        // botão de deixa o numero negativo
        private void button18_Click(object sender, EventArgs e)
        {

        }

        //fundo
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
