using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Titulo
    {
        public Titulo()
        {
            Empleado = new HashSet<Empleado>();
        }

        public short IdTituloObtenido { get; set; }
        public string Titulo1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
