namespace HotelWebservice1_LocalDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelViewContext : DbContext
    {
        public HotelViewContext()
            : base("name=HotelViewContext")
        {
        }

        public virtual DbSet<HotelRoomView> HotelRoomView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoomView>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HotelRoomView>()
                .Property(e => e.Types)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
