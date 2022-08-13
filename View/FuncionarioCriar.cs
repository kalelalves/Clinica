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
    public partial class FuncionarioCriar : Form
    {
        public FuncionarioCriar()
        {
            InitializeComponent();
        }

        private void FuncionarioCriar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = this.nomeValor.Text;
            funcionario.idade = int.Parse(this.idadeValor.Text);
            funcionario.cidade = this.cidadeValor.Text;
            funcionario.cpf = this.cpfValor.Text;
            funcionario.cargo = this.cargoValor.Text;
            funcionario.salario = double.Parse(this.salarioValor.Text);

            FuncionarioController funcionarioController = new FuncionarioController();
            funcionarioController.criar(funcionario);
            this.Close();
        }
    }
}
