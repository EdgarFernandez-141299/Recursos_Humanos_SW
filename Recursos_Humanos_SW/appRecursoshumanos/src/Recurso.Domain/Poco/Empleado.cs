using System;
using System.Collections.Generic;

namespace Recurso.Domain.Poco
{
    public partial class Empleado
    {
        public long IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string TelefonoLocal { get; set; }
        public string TelefonoMovil { get; set; }
        public string Direccion { get; set; }
        public DateTime? FecNac { get; set; }
        public string Curp { get; set; }
        public string Observaciones { get; set; }
        public string Email { get; set; }
        public DateTime? InsFec { get; set; }
        public string CodigoPostal { get; set; }
        public string EstadoNacimiento { get; set; }
        public string IdGenero { get; set; }
        public short IdTituloObtenido { get; set; }
        public string Nacionalidad { get; set; }
        public byte? TrabajaActualmente { get; set; }
        public short IdDiscapacidad { get; set; }
        public string RedSocial { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string UnidadMedicinaFamiliar { get; set; }
        public string ComunidadIndigena { get; set; }
        public byte? ProcedeComunidadIndigena { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public long IdPuesto { get; set; }
        public string Rfc { get; set; }
        public short? Estatura { get; set; }
        public short? Peso { get; set; }
        public decimal? SueldoDeseado { get; set; }
        public int IdEstadoNac { get; set; }

        public virtual Discapacidad IdDiscapacidadNavigation { get; set; }
        public virtual Estado IdEstadoNacNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual Puesto IdPuestoNavigation { get; set; }
        public virtual Titulo IdTituloObtenidoNavigation { get; set; }
    }
}
