namespace HInfrastructure.Persistence.DataContext
{
    using System.Data.Entity;
    public class StoreDataContext : DbContext
    {
        public StoreDataContext()
            : base("StoreConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

 //       public DbSet<User> Users { get; set; }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
   //         modelBuilder.Configurations.Add(new UserMap());
   
        }
    }
}

