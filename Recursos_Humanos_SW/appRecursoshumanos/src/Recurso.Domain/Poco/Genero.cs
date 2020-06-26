using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Genero
    {
        public Genero()
        {
            Empleado = new HashSet<Empleado>();
        }

        public string IdGenero { get; set; }
        public string Genero1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
