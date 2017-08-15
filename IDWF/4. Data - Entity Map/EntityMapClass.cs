using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using $solutionname$.Data.Entities;
using Puppy.EF.Mapping;

namespace $rootnamespace$
{
    public class $safeitemname$: IEntityTypeConfiguration<$fileinputname$Entity>
	{
        public void Map(EntityTypeBuilder<$fileinputname$Entity> builder)
        {
            builder.ToTable(nameof($fileinputname$Entity));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Version).IsRowVersion();
        }
    }
}