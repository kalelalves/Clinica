using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
         //   this.listagem.DataSource = banco.ExecultaSlect(str);

        }
        public Pacientes(DataTable pacientes)
        {

            InitializeComponent();
            this.listagem.DataSource = pacientes;

        }


        //public Pacientes(ArrayList pacientes)
        //{


        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriar pacienteCriar = new PacientesCriar();
            pacienteCriar.Show();
            this.Close();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }

        private void listagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String doenca = this.listagem.Rows[rowindex].Cells[2].Value.ToString(); //doenca
            String idade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();// idade
            String cidade = this.listagem.Rows[rowindex].Cells[4].Value.ToString(); // cidade
            String cpf = this.listagem.Rows[rowindex].Cells[5].Value.ToString(); // cpf
            Paciente paciente = new Paciente();
            paciente.codp = int.Parse(codp);
            paciente.nome = nome;
            paciente.idade = int.Parse(idade);
            paciente.cpf = cpf;
            paciente.cidade = cidade;
            paciente.doenca = doenca;

            PacienteController controller = new PacienteController();
            controller.deletar(paciente);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String doenca = this.listagem.Rows[rowindex].Cells[2].Value.ToString(); //doenca
            String idade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();// idade
            String cidade = this.listagem.Rows[rowindex].Cells[4].Value.ToString(); // cidade
            String cpf = this.listagem.Rows[rowindex].Cells[5].Value.ToString(); // cpf
            Paciente paciente = new Paciente();
            paciente.codp = int.Parse(codp);
            paciente.nome = nome;
            paciente.idade = int.Parse(idade);
            paciente.cpf = cpf;
            paciente.cidade = cidade;
            paciente.doenca = doenca;

            PacienteController controller = new PacienteController(); 
            controller.alterar(paciente);
            this.Close();
        }
    }
}
