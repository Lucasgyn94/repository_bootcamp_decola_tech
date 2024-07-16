using DIO.Series.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series.Web.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
    {
        // Metodo que vai devolver dados
        /*
         GET = Retornar algo
         POST = Inserir algo
         PUT = Alterar algo
         DELETE = Excluir algo
         */

        // Instanciando o repositório
        private readonly IRepositorio<Serie> _repositorioSerie;

        // Injeção de dependência
        public SerieController(IRepositorio<Serie> repositorioSerie)
        {
            _repositorioSerie = repositorioSerie;
        }

        [HttpGet("")]
        public IActionResult Lista()
        {
            // essa lista devolve uma lista de series model
            return Ok(_repositorioSerie.Lista().Select(s => new SerieModel(s)));
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody]SerieModel model)
        {
            _repositorioSerie.Atualiza(id, model.ToSerie()); // AutoMapper
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Exclui(int id)
        {
            _repositorioSerie.Exclui(id);
            return NoContent();
        }

        [HttpPost("")]
        public IActionResult Insere([FromBody] SerieModel model)
        {
            model.Id = _repositorioSerie.ProximoId();

            Serie serie = model.ToSerie();

            _repositorioSerie.Insere(serie);
            return Created("", serie);
        }

        [HttpGet("{id}")]
        public IActionResult Consulta(int id)
        {
            return Ok(new SerieModel(_repositorioSerie.Lista().FirstOrDefault(s => s.Id == id)));
        }
    }
}
