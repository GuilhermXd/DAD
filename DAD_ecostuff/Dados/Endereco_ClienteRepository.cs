using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dados
{
    public class Endereco_ClienteRepository
    {
       

        public string Inserir(Endereco_Cliente endereco)
        {
            string resp = "";
            try
            {
                // Obtém a conexão com o banco de dados
                Conexao.getConnection();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao.SqlCon,
                    CommandText = "INSERT INTO ENDERECO_CLIENTE (CEP, RUA, NUMERO, BAIRRO, CIDADE, PAIS, CLIENTE_CODIGO, ESTADO) VALUES (@pCep, @pRua, @pNumero, @pBairro, @pCidade, @pPais, @pClienteCodigo, @pEstado)",
                    CommandType = System.Data.CommandType.Text
                };

                // Adiciona os parâmetros ao comando
                cmd.Parameters.AddWithValue("@pCep", endereco.CEP);
                cmd.Parameters.AddWithValue("@pRua", endereco.Rua);
                cmd.Parameters.AddWithValue("@pNumero", endereco.Numero);
                cmd.Parameters.AddWithValue("@pBairro", endereco.Bairro);
                cmd.Parameters.AddWithValue("@pCidade", endereco.Cidade);
                cmd.Parameters.AddWithValue("@pPais", endereco.Pais);
                cmd.Parameters.AddWithValue("@pClienteCodigo", endereco.ClienteCodigo);
                cmd.Parameters.AddWithValue("@pEstado", endereco.Estado);


                // Executa o comando e verifica se a inserção foi bem-sucedida
                resp = cmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (MySqlException ex)
            {
                resp = ex.Message; // Retorna a mensagem de erro, se houver
            }
            finally
            {
                // Fecha a conexão se estiver aberta
                if (Conexao.SqlCon.State == ConnectionState.Open)
                    Conexao.SqlCon.Close();
            }

            return resp; // Retorna o resultado da operação
        }
        public string Update(Endereco_Cliente endereco)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE ENDERECO_CLIENTE SET " +
                                   "CEP = @pCep, " +
                                   "RUA = @pRua, " +
                                   "NUMERO = @pNumero, " +
                                   "BAIRRO = @pBairro, " +
                                   "CIDADE = @pCidade, " +
                                   "PAIS = @pPais, " +
                                   "CLIENTE_CODIGO = @pClienteCodigo " + 
                                   "ESTADO = @pEstado"+
                                   "WHERE CODIGO = @pCodigo"; // Removida a vírgula antes do WHERE

                using (MySqlCommand sqlCmd = new MySqlCommand(updateSql, Conexao.SqlCon))
                {
                    sqlCmd.Parameters.AddWithValue("@pCep", endereco.CEP);
                    sqlCmd.Parameters.AddWithValue("@pRua", endereco.Rua);
                    sqlCmd.Parameters.AddWithValue("@pNumero", endereco.Numero);
                    sqlCmd.Parameters.AddWithValue("@pBairro", endereco.Bairro);
                    sqlCmd.Parameters.AddWithValue("@pCidade", endereco.Cidade);
                    sqlCmd.Parameters.AddWithValue("@pPais", endereco.Pais);
                    sqlCmd.Parameters.AddWithValue("@pCodigo", endereco.Codigo);
                    sqlCmd.Parameters.AddWithValue("@pClienteCodigo", endereco.ClienteCodigo);
                    sqlCmd.Parameters.AddWithValue("@pEstado", endereco.Estado);


                    resp = sqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA"; // Retorna SUCESSO ou FALHA
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message; // Captura qualquer erro e retorna a mensagem
            }
            finally
            {
                if (Conexao.SqlCon.State == System.Data.ConnectionState.Open)
                    Conexao.SqlCon.Close(); // Fecha a conexão se estiver aberta
            }

            return resp; // Retorna a resposta final
        }

        public string Remove(int Codigo)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = String.Format("DELETE FROM  ENDERECO_CLIENTE " +
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
            DataTable DtResultado = new DataTable("Endereco_Cliente");
            try
            {
                Conexao.getConnection();
                String sqlSelect = "select * from ENDERECO_CLIENTE";

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


        public DataTable filterByClientCodigo(int? pClienteCodigo)
        {
            DataTable DtResultado = new DataTable("Endereco_Cliente");
            string selectSql;
            try
            {
                Conexao.getConnection();

                if (pClienteCodigo.HasValue)
                {
                    selectSql = "SELECT * FROM ENDERECO_CLIENTE WHERE CLIENTE_CODIGO = @pClienteCodigo";
                }
                else
                {
                    selectSql = "SELECT * FROM ENDERECO_CLIENTE"; 
                }

                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Conexao.SqlCon);

                if (pClienteCodigo.HasValue) 
                {
                    SqlCmd.Parameters.AddWithValue("@pClienteCodigo", pClienteCodigo.Value); 
                }

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

