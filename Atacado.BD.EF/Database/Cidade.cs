namespace Atacado.BD.EF.Database;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Cidade")]
public partial class Cidade
{
    [Key]
    public Int64 CodigoCidade {get; set;}

    [Unicode(false)]
    public string Nome {get; set;} = null!;

    public Int64 CodigoIBGE7 {get; set;}

    [Unicode(false)]
    public string UF {get; set;} = null!;

    public Int64 CodigoEstado { get; set; }

    public Cidade()
    {}
}
