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
    }
}
