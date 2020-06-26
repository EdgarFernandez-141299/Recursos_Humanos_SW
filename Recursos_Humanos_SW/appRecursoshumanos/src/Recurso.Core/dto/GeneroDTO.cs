
using System;
using Recurso.Domain.Poco;

namespace Recurso.Core.Dto
{
    public partial class GeneroDTO
    {
        public GeneroDTO()
        {
        }

        public string IdGenero { get; set; }
        public string Nombre { get; set; }
    }
}