using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Discapacidad
    {
        public Discapacidad()
        {
            Empleado = new HashSet<Empleado>();
        }

        public short IdDiscapacidad { get; set; }
        public string Discapacidad1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
