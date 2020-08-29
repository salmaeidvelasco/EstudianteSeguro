
namespace ApiSecureStudent.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext //Está relacionado con la base de dato
    {
        public DataContext(): base("DefaultConnection")//ctor tab tab constructor el DefaultCOn lo sacamos de web config en addname
        {
                
        }

        public System.Data.Entity.DbSet<ApiSecureStudent.Models.Student> Students { get; set; }
    }
}