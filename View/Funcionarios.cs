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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }


        public Funcionarios(DataTable funcionarios)
        {
            InitializeComponent();
            this.listagem.DataSource = funcionarios;


        }
        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            FuncionarioCriar funcionarioCriar = new FuncionarioCriar(); 
            funcionarioCriar.Show();
            this.Close();
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codf = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[1].Value.ToString(); //idade
            String cpf = this.listagem.Rows[rowindex].Cells[2].Value.ToString(); //cpf
            String cidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();// cidade
            String salario = this.listagem.Rows[rowindex].Cells[4].Value.ToString(); //salario
            String cargo = this.listagem.Rows[rowindex].Cells[5].Value.ToString(); // cargo
            String nome = this.listagem.Rows[rowindex].Cells[6].Value.ToString();// nome

            Funcionario funcionario = new Funcionario();
            funcionario.codf = int.Parse(codf);
            funcionario.nome = nome;
            funcionario.idade = int.Parse(idade);
            funcionario.cpf = cpf;
            funcionario.cidade = cidade;
            funcionario.cargo = cargo;
            funcionario.salario = double.Parse(salario);
            FuncionarioController controller = new FuncionarioController();
            controller.deletar(funcionario);
            this.Close();
        }
    }
}
