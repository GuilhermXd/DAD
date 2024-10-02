using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace Dados
{
    public class PlantaRepository
    {

        public string Inserir(Planta planta)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao.SqlCon,
                    CommandText = "INSERT INTO PLANTA( NOME, OBSERVACOES, DATA_DA_VERIFICACAO, CICLO_DE_AGUA, CICLO_DE_ILUMINACAO, TIPO_DE_SOLO) values ( @pNome, @pObservacoes, @pDatadeverificacao, @pCiclodeagua, @pCicloiluminacao, @pTipodesolo)",
                    CommandType = System.Data.CommandType.Text

                };

                cmd.Parameters.AddWithValue("pNome", planta.Nome);
                cmd.Parameters.AddWithValue("pObservacoes", planta.Observacoes);
                cmd.Parameters.AddWithValue("@pDatadeverificacao", planta.Datadeverificacao);
                cmd.Parameters.AddWithValue("@pCiclodeagua", planta.Ciclodeagua);
                cmd.Parameters.AddWithValue("@pCicloiluminacao", planta.Cicloiluminacao);
                cmd.Parameters.AddWithValue("@pTipodesolo", planta.Tiposolo);
               


                resp = cmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
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
        public string Update(Planta planta)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE PLANTA SET " +
                                   "NOME = @pNome, " +
                                   "OBSERVACOES = @pObservacoes, " +
                                   "DATA_DA_VERIFICACAO = @pDatadeverificacao, " +
                                   "CICLO_DE_AGUA = @pCiclodeagua, " +
                                   "CICLO_DE_ILUMINACAO = @pCicloiluminacao, " +
                                   "TIPO_DE_SOLO = @pTipodesolo, " +
                                   "WHERE CODIGO = @pCodigo";


                using (MySqlCommand sqlCmd = new MySqlCommand(updateSql, Conexao.SqlCon))
                {

                    sqlCmd.Parameters.AddWithValue("@pNome", planta.Nome);
                    sqlCmd.Parameters.AddWithValue("@pObservacoes", planta.Observacoes);
                    sqlCmd.Parameters.AddWithValue("@pDatadeverificacao", planta.Datadeverificacao);
                    sqlCmd.Parameters.AddWithValue("@pCiclodeagua", planta.Ciclodeagua);
                    sqlCmd.Parameters.AddWithValue("@pCicloiluminacao", planta.Cicloiluminacao);
                    sqlCmd.Parameters.AddWithValue("@pTipodesolo", planta.Tiposolo);
                    sqlCmd.Parameters.AddWithValue("@pCodigo", planta.Codigo);


                    resp = sqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
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

                string updateSql = String.Format("DELETE FROM PLANTA " +
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
            DataTable DtResultado = new DataTable("Planta");
            try
            {
                Conexao.getConnection();
                String sqlSelect = "select * from PLANTA";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.SqlCon;
                cmd.CommandText = sqlSelect;
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(cmd);
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
            DataTable DtResultado = new DataTable("Planta");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM PLANTA WHERE NOME LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM PLANTA");
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
