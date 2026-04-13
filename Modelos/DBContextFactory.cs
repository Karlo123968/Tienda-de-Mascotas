using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Usuarios.Modelos
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=UsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new DBContext(optionsBuilder.Options);
        }
    }
}