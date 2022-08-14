using Clinica.Controller;
using System;
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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();


        }


        public Medicos(object medicos)
        {
            InitializeComponent();
            this.listagem.DataSource = medicos;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void criarmedBtn_Click(object sender, EventArgs e)
        {
            MedicosCriar medicosCriar = new MedicosCriar();
            medicosCriar.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;
            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();

            Medico medico = new Medico();
            medico.codm = int.Parse(codm);

            MedicosController controller = new MedicosController();
            controller.deletar(medico);
            this.Close();
        }

        private void editarBTn_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;
            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nrao = this.listagem.Rows[rowindex].Cells[1].Value.ToString();//nrao
            String cidade = this.listagem.Rows[rowindex].Cells[2].Value.ToString(); //cidade
            String nome = this.listagem.Rows[rowindex].Cells[3].Value.ToString();// nome
            String idade = this.listagem.Rows[rowindex].Cells[4].Value.ToString(); // idade
            String especialidade = this.listagem.Rows[rowindex].Cells[5].Value.ToString(); // especialidade
            String cpf = this.listagem.Rows[rowindex].Cells[6].Value.ToString(); //cpf

            if(nrao==""||nrao==null)
            {
                nrao = "000";
            }
            Medico medico = new Medico();
            medico.codm = int.Parse(codm);
            medico.nrao = int.Parse(nrao);
            medico.nome = nome;
            medico.especialidade = especialidade;
            medico.cidade = cidade;
            medico.idade = int.Parse(idade);
            medico.cpf = cpf;

            MedicosController controller = new MedicosController();
            controller.alterar(medico);
            this.Close();
        }
    }
}
