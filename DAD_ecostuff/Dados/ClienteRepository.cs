using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ClienteRepository
    {
        public string Inserir(Cliente cliente)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                MySqlCommand Sqlcmd = new MySqlCommand
                {
                    Connection = Conexao.SqlCon,
                    CommandText = "INSERT INTO CLIENTE( NOME, EMAIL, CPF_CNPJ, RG, CELULAR,SENHA) values ( @pNome, @pEmail, @pCpf_Cnpj, @pRg, @pCelular, @pSenha)",
                    CommandType = System.Data.CommandType.Text

                };
                
                Sqlcmd.Parameters.AddWithValue("pNome", cliente.Nome);
                Sqlcmd.Parameters.AddWithValue("pEmail", cliente.Email);
                Sqlcmd.Parameters.AddWithValue("pCpf_Cnpj", cliente.Cpf_Cnpj);
                Sqlcmd.Parameters.AddWithValue("@pRg", cliente.Rg);
                Sqlcmd.Parameters.AddWithValue("@pCelular", cliente.Celular);
                Sqlcmd.Parameters.AddWithValue("@pSenha", cliente.Senha);



                resp = Sqlcmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (MySqlException ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Conexao.SqlCon.State == ConnectionState.Open)
                    Conexao.SqlCon.Close();
            }


            return resp;


        }
        public string Update(Cliente cliente)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE CLIENTE SET " +
                                   "NOME = @pNome, " +
                                   "EMAIL =@PEmail" +
                                   "CPF_CNPJ = @pCpf_Cnpj, " +
                                   "RG = @pRg, " +
                                   "CELULAR = @pCelular, " +
                                   "SENHA = @pSenha, " +
                                   "WHERE CODIGO = @pCodigo";


                using (MySqlCommand Sqlcmd = new MySqlCommand(updateSql, Conexao.SqlCon))
                {


                    Sqlcmd.Parameters.AddWithValue("pNome", cliente.Nome);
                    Sqlcmd.Parameters.AddWithValue("pEmail", cliente.Email);
                    Sqlcmd.Parameters.AddWithValue("pCpf_Cnpj", cliente.Cpf_Cnpj);
                    Sqlcmd.Parameters.AddWithValue("@pRg", cliente.Rg);
                    Sqlcmd.Parameters.AddWithValue("@pCelular", cliente.Celular);
                    Sqlcmd.Parameters.AddWithValue("@pSenha", cliente.Senha);
                    Sqlcmd.Parameters.AddWithValue("@pCodigo", cliente.Codigo);


                    resp = Sqlcmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {

                if (Conexao.SqlCon.State == System.Data.ConnectionState.Open)
                    Conexao.SqlCon.Close();
            }
            return resp;
        }

        public string Remove(int Codigo)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = String.Format("DELETE FROM CLIENTE " +
                                    "WHERE CODIGO = @pCodigo ");
                MySqlCommand cmd = new MySqlCommand(updateSql, Conexao.SqlCon);
                cmd.Parameters.AddWithValue("pCodigo", Codigo);


                resp = cmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Conexao.SqlCon.State == ConnectionState.Open)
                    Conexao.SqlCon.Close();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("Cliente");
            try
            {
                Conexao.getConnection();
                String sqlSelect = "select * from CLIENTE";

                MySqlCommand Sqlcmd = new MySqlCommand();
                Sqlcmd.Connection = Conexao.SqlCon;
                Sqlcmd.CommandText = sqlSelect;
                Sqlcmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(Sqlcmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByName(string pNome)
        {
            DataTable DtResultado = new DataTable("Cliente");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM CLIENTE WHERE NOME LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM CLIENTE");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Conexao.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
