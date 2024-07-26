﻿using CustomMiddleware.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            throw new NullReferenceException();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategoriesById(int id) 
        {
          List<Category> list = new List<Category>();
            list.Add(new Category { Id = 1, Name = "Abc" });
            list.Add(new Category { Id = 2, Name = "Abc2" });
            var cat = list.Where(x => x.Id == id).First();
            return Ok(cat);
        }
    }
}
