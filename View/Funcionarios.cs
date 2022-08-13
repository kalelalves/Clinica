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
    }
}
