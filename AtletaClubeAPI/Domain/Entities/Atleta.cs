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
    public class Atleta : BaseEntity
    {
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Nacionalidade { get; set; }

        [Column(TypeName = "int")]
        public int Idade { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Posicao { get; set; }

        [ForeignKey("Clube")]
        public int ClubeId { get; set; }
    }
}
