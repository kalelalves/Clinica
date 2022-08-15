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
    public partial class ConsultasEditar : Form
    {
        public ConsultasEditar(object consulta)
        {
            InitializeComponent();
            Consulta c = (Consulta)consulta;
            this.codigoValor.Text = c.codm.ToString();
            this.codpValor.Text = c.codp.ToString();
            this.dataValor.Text = c.data.ToString();
            this.horaValor.Text = c.hora.ToString();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();

        }

        private void ConsultasEditar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.codm = int.Parse(codigoValor.Text);
            consulta.codp= int.Parse(codpValor.Text);
            consulta.data = dataValor.Text;
            consulta.hora = horaValor.Text;

            ConsultaController consultaController =new  ConsultaController();
            consultaController.salvar(consulta);
            this.Close();
        }
    }
}
