using ProjetoEstudoTaskool.Model;
using ProjetoEstudoTaskool.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstudoTaskool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuario().ShowDialog();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectIdioma.Items.Add("Inglês");
            selectIdioma.Items.Add("Português");
        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Usuario u = new Usuario();

            //if (u.UserName = inputUser && u.Senha = inputSenha)
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
