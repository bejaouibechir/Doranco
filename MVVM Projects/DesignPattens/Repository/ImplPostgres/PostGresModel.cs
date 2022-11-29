using Npgsql; //Entity Framework pour postgresql 
using System.Data.Entity;


namespace DesignPattens.Repository.ImplPostGres
{
    public partial class PostGresModel :DbContext
    {
        public PostGresModel()
            : base("name=PostGresModel")
        {

        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
    }
}
