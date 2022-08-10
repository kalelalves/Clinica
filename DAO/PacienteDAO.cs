using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;

namespace Clinica
{
    internal class PacienteDAO : IDAO
    {
        public DataTable all()
        {
            DataTable lista;
            try
            {
                string str = "select * from pacientes;";
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

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
