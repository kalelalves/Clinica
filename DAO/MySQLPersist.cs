using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clinica
{
     /// <summary>
      /// Classe para conectar ao MySql.
      /// </summary>
    public class MySQLPersist
    {

        MySqlConnection _conexao;
        MySqlCommand _cmd;
        bool _fecharConexaoAutomaticamente = true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecharConexaoAutomaticamente"></param>
        public MySQLPersist(bool fecharConexaoAutomaticamente = true)
        {
            _fecharConexaoAutomaticamente = fecharConexaoAutomaticamente;
            _conexao = new MySqlConnection("server=localhost;port=3306;Database=clinica;Uid=kalel;Password=kalel1234;");
            _cmd = _conexao.CreateCommand();
        }


        /// <summary>
        /// Abre uma conexão com o MySql.
        /// </summary>
        public void AbrirConexao()
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();
        }


        /// <summary>
        /// Fecha uma conexão com o MySql.
        /// </summary>
        public void FecharConexao()
        {
            _conexao.Clone();
        }


        /// <summary>
        /// Executa um comando SELECT
        /// </summary>
        /// <param name="select">Variavel que que recebe o sql para execução</param>
        /// <param name="parametros">Recebe parametros quando necessário</param>
        /// <returns></returns>
        public DataTable ExecultaSlect(string select, List<MySqlParameter> parametros = null)
        {
            DataTable dt = new DataTable();
            _cmd.CommandText = select;

            if (parametros != null)
            {
                _cmd.Parameters.AddRange(parametros.ToArray());
            }
                AbrirConexao();
                dt.Load(_cmd.ExecuteReader()); //Ler dados

            
            if (_fecharConexaoAutomaticamente)
            {
                FecharConexao();
            }

            
            return dt;

        }


        /// <summary>
        /// Executa Insert, Delete, Update e Stored Procedure
        /// </summary>
        /// <param name="sql">Variavel que que recebe o comando para execução</param>
        /// <param name="parametros">Recebe parametros quando necessário</param>
        /// <returns></returns>
        public int ExecutaNonQuery(string sql, List<MySqlParameter> parametros = null)
        {
            int linhasAfetadas = 0;
            _cmd.CommandText = sql;

            if(parametros!=null)
            {
                _cmd.Parameters.AddRange(parametros.ToArray());
                AbrirConexao();
                linhasAfetadas = _cmd.ExecuteNonQuery();
            }

            if(_fecharConexaoAutomaticamente)
            {
                FecharConexao();
            }

            return linhasAfetadas;
        }


        public object ExecutaScalar(string sql, List<MySqlParameter> parametros=null )
        {
            object result = null;
            _cmd.CommandText = sql;
            if (parametros != null)
            {
                _cmd.Parameters.AddRange(parametros.ToArray());
                AbrirConexao();
                result = _cmd.ExecuteScalar();
            
            }
            if(_fecharConexaoAutomaticamente)
            {
                FecharConexao();
            }
            return result;
        }


        public void AdicionarParametro(string nome, object valor)
        {
            _cmd.Parameters.AddWithValue(nome, valor);
        }


        public Int64 ExecuteNonQueryLastKey(string sql, List<MySqlParameter> parametros = null)
        {
           
            Int64 lastId = 0;            
            _cmd.CommandText = sql;           
            if (parametros != null)
            {
                _cmd.Parameters.AddRange(parametros.ToArray());
            }     
                   
            AbrirConexao();

            _cmd.ExecuteNonQuery();
            lastId = _cmd.LastInsertedId;

            if (_fecharConexaoAutomaticamente)
                FecharConexao();


            return lastId;
        }


    }
}