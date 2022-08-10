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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void criarmedBtn_Click(object sender, EventArgs e)
        {
            MedicosCriar medicosCriar = new MedicosCriar();
            medicosCriar.Show();
            this.Close();
        }
    }
}
