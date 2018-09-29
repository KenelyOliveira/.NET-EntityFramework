using Kenely_EntityFramework.Entity;
using System.Data.Entity;

namespace Kenely_EntityFramework.Models
{
  public class PegaSATContext : DbContext
  {
    // Your context has been configured to use a 'BackofficeModel' connection string from your application's 
    // configuration file (App.config or Web.config). By default, this connection string targets the 
    // 'Kenely_EntityFramework.Models.BackofficeModel' database on your LocalDb instance. 
    // 
    // If you wish to target a different database and/or database provider, modify the 'BackofficeModel' 
    // connection string in the application configuration file.
    public PegaSATContext()
        : base("name=PegaSATContext")
    {
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    public virtual DbSet<Usuario> Usuario { get; set; }
    public virtual DbSet<Perfil> Perfil { get; set; }
  }

  //public class MyEntity
  //{
  //    public int Id { get; set; }
  //    public string Name { get; set; }
  //}
}
