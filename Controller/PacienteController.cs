using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class PacienteController
    {
        public void listar()
        {
            PacienteDAO pacientesDAO = new PacienteDAO();
            DataTable lista = pacientesDAO.all();
            Pacientes pacientes = new Pacientes(lista);
            pacientes.Show();
        }
    }
}
