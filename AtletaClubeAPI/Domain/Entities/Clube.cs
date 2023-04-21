using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Clube : BaseEntity
    {
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cidade { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Sigla { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Estadio { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Treinador{ get; set; }
    }
}
