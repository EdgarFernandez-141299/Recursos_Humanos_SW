using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Estado
    {
        public Estado()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int IdEstadoNac { get; set; }
        public string Estado1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
