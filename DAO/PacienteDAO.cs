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
            Paciente paciente = (Paciente)objeto;
            MySQLPersist banco = new MySQLPersist();

            try
            {
              
               string sql= "INSERT INTO pacientes" +
                    "(nome,idade,cidade,cpf,doenca) " +
                    "VALUES(@nome,@idade,@cidade,@cpf,@doenca)";

                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@nome", paciente.nome));
                parametros.Add(new MySqlParameter("@idade", paciente.idade));
                parametros.Add(new MySqlParameter("@cidade", paciente.cidade));
                parametros.Add(new MySqlParameter("@cpf", paciente.cpf));
                parametros.Add(new MySqlParameter("@doenca", paciente.doenca));

                int id = Convert.ToInt32( banco.ExecuteNonQueryLastKey(sql,parametros));       
                paciente.codp = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
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
