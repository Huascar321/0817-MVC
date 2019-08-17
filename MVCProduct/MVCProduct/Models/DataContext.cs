using System.Data.Entity;


namespace MVCProduct.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCProduct.Models.Product> Products { get; set; }
    }
}