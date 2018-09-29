using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenely.EntityFramework.Repository.Repositories
{
  public class UsuarioRepository
  {
    public ILogger Logger { get; }
    public UsuarioRepository(ILoggerFactory loggerFactory)
    {
      Logger = loggerFactory?.CreateLogger<UsuarioRepository>();
      if (Logger == null)
      {
        throw new ArgumentNullException(nameof(loggerFactory));
      }
      Logger.LogInformation("Repository");
    }

  }
}
