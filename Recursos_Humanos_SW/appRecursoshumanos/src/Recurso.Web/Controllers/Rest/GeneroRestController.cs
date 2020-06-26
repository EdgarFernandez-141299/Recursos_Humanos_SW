using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Recurso.Web.Models;
using Recurso.Domain.Poco;
using Recurso.Core.Dto;
using Microsoft.EntityFrameworkCore;

namespace Recurso.Web.Rest{

    [ApiController]

    public class GeneroRestController : ControllerBase {

        private  db_RecursohumanoContext  _recursoContext;

        public GeneroRestController(db_RecursohumanoContext context){
            this._recursoContext = context;
        }

       
       [HttpGet("genero/catalogo")]
       public IEnumerable<GeneroDTO> GetGeneros(){
           // Formato en programación funcional
           return _recursoContext.Genero.Select(x => new GeneroDTO(){ IdGenero = x.IdGenero, Nombre = x.Genero1 }).ToList();
       }      


        [HttpPost("genero/agrega")]
        public async Task<ActionResult<Genero>> PostAgregaGenero(Genero pGenero){

            _recursoContext.Genero.Add(pGenero);
            await _recursoContext.SaveChangesAsync();

           // return.CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetGeneros), new {id = pGenero.IdGenero}, pGenero);
        }


        [HttpGet("genero/{id}")]
        public async Task<ActionResult<Genero>> GetGenero(string id){

            var oGenero = await _recursoContext.Genero.FindAsync(id);
            if(oGenero == null){
                return NotFound();
            }
            return oGenero;

        }   

        [HttpDelete("genero/elimina/{id}")]

        public async Task<ActionResult<Genero>> DeleteGenero(string id){
            var oGenero = await _recursoContext.Genero.FindAsync(id);
            if(oGenero == null){
                return NotFound();
            }
            _recursoContext.Genero.Remove(oGenero);
            await _recursoContext.SaveChangesAsync();
            return oGenero;
        }     


        [HttpPut("genero/actualiza/{id}")]

        public async Task<IActionResult> PutGenero(string id, Genero pGenero){

            if(id != pGenero.IdGenero){
                return BadRequest();
            }

            try{
                _recursoContext.Update(pGenero);
                await _recursoContext.SaveChangesAsync();

            }catch(DbUpdateConcurrencyException){

                if(!GeneroExists(id)){
                    return NotFound();
                }else{
                    throw;
                }

            }
            return NoContent();

        }    

        private bool GeneroExists(string pId){
            return _recursoContext.Genero.Any(e=> e.IdGenero == pId);
        }
    
    }
}