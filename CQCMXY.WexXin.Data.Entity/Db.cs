namespace CQCMXY.WeiXin.Data.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
            Database.SetInitializer<Db>(new Initializer());
        }
        public virtual DbSet<AppInterfaceInfo> AppInterfaceInfo { get; set; }
        public virtual DbSet<AppTokenInfo> AppTokenInfo { get; set; }
        public virtual DbSet<menus> menus { get; set; }
        public virtual DbSet<MenusButtonAction> MenusButtonAction { get; set; }
        public virtual DbSet<NewMsgs> NewMsgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppInterfaceInfo>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<AppTokenInfo>()
                .Property(e => e.Timestamp)
                .IsFixedLength();


            modelBuilder.Entity<menus>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<MenusButtonAction>()
                .Property(e => e.Timestamp)
                .IsFixedLength();


            modelBuilder.Entity<NewMsgs>()
                .Property(e => e.Timestamp)
                .IsFixedLength();
        }
    }
}
