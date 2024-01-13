using Domus.Domain.Entities;
using Domus.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domus.Domain.Mappings.DatabaseMappings;

public class ProductPriceModelMapper : IDatabaseModelMapper
{
    public void Map(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductPrice>(entity =>
        {
            entity.ToTable(nameof(ProductPrice));

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MonetaryUnit).HasMaxLength(256);

            entity.HasOne(d => d.ProductDetail).WithMany(p => p.ProductPrices)
                .HasForeignKey(d => d.ProductDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductPr__Produ__5812160E");
        });
    }
}
