using Clinica.DAO;
using Clinica.Models;
using Clinica.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Controller
{
    internal class FuncionarioController
    {

        public void listar()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            DataTable lista = funcionarioDAO.all();
            Funcionarios funcionarios = new Funcionarios(lista);
            funcionarios.Show();
        }
       
    }
}
