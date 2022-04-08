using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static readonly List<Filme> filmes = new();
        private static  int id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme) 
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes() 
        { 
            return filmes; 
        }


        [HttpGet("{id}")]
        public Filme RecuperarFilmesPorId(int id)
        {
            return filmes.Find(filme => filme.Id == id);
        }
    }
}
