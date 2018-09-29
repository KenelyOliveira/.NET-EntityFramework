using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kenely_EntityFramework.Entity
{
  [Table("Usuarios")]
  public class Usuario 
  {
    public int Id { get; set; }
    public string Login { get; set; }
    public string Nome { get; set; }
    public bool IsAdministrador { get; set; }
    public bool IsExcluido { get; set; }
  }
}
