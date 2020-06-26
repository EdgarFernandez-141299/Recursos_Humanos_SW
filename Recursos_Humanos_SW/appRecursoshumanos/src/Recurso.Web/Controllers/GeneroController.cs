using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recurso.Web;
using Recurso.Core.Dto;
using Microsoft.EntityFrameworkCore;
using Recurso.Domain.Poco;

namespace Recurso.Web.Controllers{
    public class GeneroController : Controller{
        private db_RecursohumanoContext _recursoContext;
        public GeneroController(db_RecursohumanoContext context)
        {
            this._recursoContext = context;
        }

        
        public async Task<IActionResult> Index(string searchString){

            var tmpGenero = from qryGenero in _recursoContext.Genero
            select qryGenero;

                if (!String.IsNullOrEmpty(searchString)){
                    tmpGenero = tmpGenero.Where(s => s.Genero1.Contains(searchString));
                }
            return View(await  tmpGenero.ToListAsync());

        }

  // GET: Movies/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oGenero = await _recursoContext.Genero.FirstOrDefaultAsync(m => m.IdGenero == id);

            if (oGenero == null){
                return NotFound();
            }

            return View(oGenero);
        }



// GET: Movies/Edit/5
        public async Task<IActionResult> Edit(string? id){

            if (id == null){
                return NotFound();
            }

            var oGenero = await _recursoContext.Genero.FindAsync(id);

            if (oGenero == null){
                return NotFound();
            }
            return View(oGenero);
        }


         // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdGenero,Genero1")] Genero pGenero)
        {
            if (id != pGenero.IdGenero){
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _recursoContext.Update(pGenero);
                    await _recursoContext.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!GeneroExists(pGenero.IdGenero)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pGenero);
        }


        private bool GeneroExists(string pId){
            return _recursoContext.Genero.Any(e => e.IdGenero == pId);
        }                


        // POST: Movies/Create
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGenero,Genero1")] Genero pGenero)
        {
            if (ModelState.IsValid) {
                _recursoContext.Add(pGenero);
                await _recursoContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pGenero);
        }

   // GET: Movies/Create
        public IActionResult Create(){
            return View(new Genero());
        }        

 // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null){
                return NotFound();
            }

            var oGenero = await _recursoContext.Genero.FirstOrDefaultAsync(m => m.IdGenero == id);
            
            if (oGenero == null){
                return NotFound();
            }

            return View(oGenero);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var oGenero = await _recursoContext.Genero.FindAsync(id);
            _recursoContext.Genero.Remove(oGenero);
            await _recursoContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }        



    }

}