using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfApiUsuario.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Column(TypeName ="nvarchar(30)")]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Sobrenome { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Email { get; set; }
        
        public DateTime DtNascimento { get; set; }

        public int Escolaridade { get; set; }
    }
}
