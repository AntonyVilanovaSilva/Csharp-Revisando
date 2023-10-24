using Concessonária.Models;
using Dapper;
using System.Data.SqlClient;

namespace Concessonária.DAL
{
    public class CaminhaoDAO
    {
        public SqlConnection _conexao;
        public CaminhaoDAO() { 
       
            _conexao = ConexaoBD.getconexao();

        }

        public List<Caminhao> getTodosCaminhaos()
        {
            var sql = "select * from Caminhao";
            var dados = (List<Caminhao>)_conexao.Query<Caminhao>(sql);
            return dados;
        }

        public bool InserirCaminhao(Caminhao caminhao)
        {
            try
            {
                var sql = "Insert Caminhao(cam_modelo,cam_ano,cam_cor) values (@cam_modelo,@cam_ano,@cam_cor)";
                var dados = _conexao.Execute(sql,caminhao);
                return dados > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Apagar(Caminhao caminhao)
        {
            var sql = "delete from Caminhao where cam_id = @cam_id";
            var dados = _conexao.Execute(sql, caminhao);
        }

        public bool UpdateCaminhao(Caminhao caminhao)
        {
            try
            {
                var sql = "update Caminhao set cam_modelo = (@cam_modelo), cam_ano = (@cam_ano), cam_cor = (@cam_cor)";
                var dados = _conexao.Execute(sql, caminhao);
                return dados > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
