using Clinica.Controller;
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

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.codf = int.Parse(this.codigoValor.Text);
            funcionario.nome = this.nomeValor.Text;
            funcionario.cpf = this.cpfValor.Text;
            funcionario.idade = int.Parse(this.idadeValor.Text);
            funcionario.cidade = this.cidadeValor.Text;
            funcionario.cargo = this.cargoValor.Text;
            funcionario.salario = double.Parse(this.salarioValor.Text);
            FuncionarioController controller = new FuncionarioController();
            controller.salvar(funcionario);
            this.Close();
        }
    }
}
