using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database;
    [Table("Banco")]
    public partial class Banco
    {
        public Banco()
        { }

        [Key]
        public Int32 CodigoBanco { get; set; }

        public Int32? CodigoBacen { get; set; }
        [Unicode(false)]
        public string? Descricao { get; set; }
        [Unicode(false)]
        public string? SiteBanco { get; set; }
        public bool? Situacao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

    }

