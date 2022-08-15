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
    public partial class ConsultasCriar : Form
    {
        public ConsultasCriar()
        {
            InitializeComponent();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.codm = int.Parse(codigoValor.Text);
            consulta.codp = int.Parse(codpValor.Text);
            consulta.data = dataValor.Text;
            consulta.hora = horaValor.Text;

            ConsultaController consultaController = new ConsultaController();
            consultaController.criar(consulta);
            this.Close();

        }
    }
}
