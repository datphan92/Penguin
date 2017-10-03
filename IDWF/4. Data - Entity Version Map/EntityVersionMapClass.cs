using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using $solutionname$.Data.Entities;
using Puppy.EF.Mapping;

namespace $rootnamespace$
{
    public class $safeitemname$: EntityVersionTypeConfiguration<$fileinputname$Entity>
	{
        public override void Map(EntityTypeBuilder<$fileinputname$Entity> builder)
        {
			base.Map(builder);

            builder.ToTable(nameof($fileinputname$Entity));
        }
    }
}