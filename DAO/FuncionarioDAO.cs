using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAO
{
    internal class FuncionarioDAO : IDAO
    {
        public DataTable all()
        {
            DataTable lista;
            try
            {
                string str = "select * from funcionarios;";
                MySQLPersist banco = new MySQLPersist();
                lista = banco.ExecultaSlect(str);
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object create(object objeto)
        {
            throw new NotImplementedException();
        }

        public void delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public void update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
