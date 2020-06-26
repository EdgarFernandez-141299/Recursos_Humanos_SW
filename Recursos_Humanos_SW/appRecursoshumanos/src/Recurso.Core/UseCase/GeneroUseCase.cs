using System;
using System.Collections.Generic;
using Recurso.Domain.Poco;

namespace Recurso.Core.UseCase
{
    public partial class GeneroUseCase
    {


        public void InsertaGenero(Genero pGenero){
            using (var context = new db_RecursohumanoContext()){
/*              var oGenero = new Genero();
                oGenero.IdGenero = "F";
                oGenero.Nombre ="Prueba";  */
                context.Genero.Add(pGenero);
                context.SaveChanges();
            }
        }



        
       public void ActualizaGenero(){
            using (var context = new db_RecursohumanoContext()){
                var oGenero = new Genero();
                oGenero.IdGenero = "H";
                oGenero.Genero1 ="Prueba de actualizacion";  
                context.Update(oGenero);
                context.SaveChanges();
            }
        }


        public void EliminaGenero(){
            using (var context = new db_RecursohumanoContext()){
                var oGenero = new Genero();
                oGenero.IdGenero = "F";
                context.Genero.Remove(oGenero);
                context.SaveChanges();
            }
        }

    }
}
