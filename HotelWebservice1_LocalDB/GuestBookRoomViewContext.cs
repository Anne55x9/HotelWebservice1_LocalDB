namespace HotelWebservice1_LocalDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuestBookRoomViewContext : DbContext
    {
        public GuestBookRoomViewContext()
            : base("name=GuestBookRoomViewContext")
        {
        }

        public virtual DbSet<GuestBookR> GuestBookR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestBookR>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
