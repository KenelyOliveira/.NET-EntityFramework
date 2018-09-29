using Kenely_EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kenely_EntityFramework.Models
{
  [Table("Perfil")]
  public class Perfil
  {
    public int Id { get; set; }
    public string Descricao { get; set; }

    public int IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    public virtual Usuario Usuario { get; set; }
    public DateTime DataAlteracao { get; set; }
    public bool IsExcluido { get; set; }
  }
}
