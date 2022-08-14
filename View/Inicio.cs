using Clinica.Controller;
using Clinica.View;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            PacienteController pacienteController = new PacienteController();
            pacienteController.listar();

            this.Hide();
        }

        private void medicoBtn_Click(object sender, EventArgs e)
        {
           MedicosController medicosController = new MedicosController();
            medicosController.listar();
            this.Hide();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
            this.Hide();
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            FuncionarioController funcionariosController = new FuncionarioController();
            funcionariosController.listar();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
