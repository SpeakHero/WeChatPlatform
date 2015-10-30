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
        }

        public virtual DbSet<AppInterfaceInfo> AppInterfaceInfo { get; set; }
        public virtual DbSet<AppTokenInfo> AppTokenInfo { get; set; }
        public virtual DbSet<menus> menus { get; set; }
        public virtual DbSet<NewMsgs> NewMsgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppTokenInfo>()
                .HasMany(e => e.AppInterfaceInfo)
                .WithRequired(e => e.AppTokenInfo)
                .HasForeignKey(e => e.AppTokenId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppTokenInfo>()
                .HasMany(e => e.menus)
                .WithRequired(e => e.AppTokenInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<menus>()
                .Property(e => e.pid)
                .IsFixedLength();

            modelBuilder.Entity<menus>()
                .HasMany(e => e.NewMsgs)
                .WithRequired(e => e.menus)
                .HasForeignKey(e => e.meunsId)
                .WillCascadeOnDelete(false);
        }
    }
}
