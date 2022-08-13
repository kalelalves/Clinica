using Clinica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.View
{
    public partial class FuncionariosEditar : Form
    {
        public FuncionariosEditar(object funcionario)
        {
            InitializeComponent();
            Funcionario f = (Funcionario)funcionario;
            this.codigoValor.Text = f.codf.ToString();
            this.nomeValor.Text = f.nome.ToString();
            this.idadeValor.Text = f.idade.ToString();
            this.cpfValor.Text= f.cpf.ToString();
            this.cidadeValor.Text = f.cidade;
            this.cargoValor.Text = f.cargo;
            this.salarioValor.Text = f.salario.ToString();
        }

        private void FuncionariosEditar_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
