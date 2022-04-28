using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenu
{
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Atualizar atu;
        Consultar con;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            con = new Consultar();
            exc = new Excluir();
        }//fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();//Mostrar a tela ao ser chamada
            Visible = true;
        }//fim do botão cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog();
            Visible = true;
        }//fim do botão consultar

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog();
            Visible = true;
        }//fim do botão atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog();
            Visible = true;
        }//fim do botão excluir
    }//fim da classe
}//fim do projeto
