using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Puesto
    {
        public Puesto()
        {
            Empleado = new HashSet<Empleado>();
        }

        public long IdPuesto { get; set; }
        public string Puesto1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
