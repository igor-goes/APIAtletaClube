using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario : BaseEntity
    {
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Sobrenome { get; set; }

        [Column(TypeName = "float")]
        public float Altura { get; set; }
        [Column(TypeName = "float")]
        public float Peso { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Senha { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataNascimento { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string  Objetivo { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Alergia { get; set; }
    }
}
