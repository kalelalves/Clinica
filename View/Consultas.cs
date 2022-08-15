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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public  Consultas(DataTable consulta)
        {
            InitializeComponent();
            this.listagem.DataSource = consulta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void novaconsultaBtn_Click(object sender, EventArgs e)
        {
            ConsultasCriar consultasCriar = new ConsultasCriar();
            consultasCriar.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String codp = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            Consulta consulta = new Consulta();
            consulta.codm = int.Parse(codm);
            consulta.codp = int.Parse(codp);

            ConsultaController controller = new ConsultaController();
            controller.deletar(consulta);
            this.Close();

        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String data = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String hora = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String codp = this.listagem.Rows[rowindex].Cells[3].Value.ToString();

            Consulta consulta = new Consulta();
            consulta.codm = int.Parse(codm);
            consulta.codp = int.Parse(codp);

            ConsultaController controller = new ConsultaController();
            controller.alterar(consulta);
            this.Close();

        }
    }
}
