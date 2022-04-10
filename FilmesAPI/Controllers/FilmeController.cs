﻿using FilmesAPI.Models;
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
        public IActionResult AdicionaFilme([FromBody] Filme filme) 
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperarFilmesPorId), new { filme.Id },filme);
        }

        [HttpGet]
        public IActionResult RecuperarFilmes() 
        {
            return Ok(filmes);
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarFilmesPorId(int id)
        {
            Filme filme = filmes.Find(filme => filme.Id == id);
            if (filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
    }
}
