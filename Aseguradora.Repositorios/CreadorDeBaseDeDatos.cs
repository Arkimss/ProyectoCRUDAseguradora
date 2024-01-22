using Microsoft.EntityFrameworkCore;
namespace Aseguradora.Repositorios
{
    public static class CreadorDeBaseDeDatos
    {
        public static void CrearAseguradora()
        {
            using (var context = new AseguradoraContext())
            {
                context.Database.EnsureCreated();
                var connection = context.Database.GetDbConnection();
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "PRAGMA journal_mode=DELETE;";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}