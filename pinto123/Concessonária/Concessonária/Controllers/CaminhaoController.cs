using Concessonária.DAL;
using Concessonária.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concessonária.Controllers
{
    public class CaminhaoController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            CaminhaoDAO caminhao = new CaminhaoDAO();
            ViewBag.Caminhao = caminhao.getTodosCaminhaos();
            return View();
        }

        [HttpGet]
        public IActionResult create() {
         
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            CaminhaoDAO caminhao = new CaminhaoDAO();
            ViewBag.Caminhao = caminhao.getTodosCaminhaos().Where(x => x.cam_id == id).FirstOrDefault();
            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> CriarCaminhao(string cam_modelo, string cam_ano, string cam_cor)
        {
            CaminhaoDAO caminhao = new CaminhaoDAO();
            Caminhao caminhao2 = new Caminhao();
            caminhao2.cam_modelo = cam_modelo;
            caminhao2.cam_ano= cam_ano;
            caminhao2.cam_cor= cam_cor;
            caminhao.InserirCaminhao(caminhao2);
            return RedirectToAction("index", "Caminhao");
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {
            CaminhaoDAO caminhao = new CaminhaoDAO();
            Caminhao caminhao2 = new Caminhao();
            caminhao2.cam_id = id;
            caminhao.Apagar(caminhao2);
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCaminhao(int id,string cam_modelo, string cam_ano, string cam_cor)
        {
            var Caminhao = new CaminhaoDAO().getTodosCaminhaos();
            var caminhao = Caminhao.First(caminhao => caminhao.cam_id.Equals(id));
            caminhao.cam_modelo = cam_modelo;
            caminhao.cam_ano = cam_ano;
            caminhao.cam_cor = cam_cor;
            new CaminhaoDAO().UpdateCaminhao(caminhao);
            return RedirectToAction("index", "Caminhao");

        }
    }
}
