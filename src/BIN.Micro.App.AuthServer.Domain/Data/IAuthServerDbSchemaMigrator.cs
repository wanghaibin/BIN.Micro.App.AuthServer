using System.Threading.Tasks;

namespace BIN.Micro.App.AuthServer.Data;

public interface IAuthServerDbSchemaMigrator
{
    Task MigrateAsync();
}
