using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using $solutionname$.Data.EF.Map.Base;
using $solutionname$.Data.Entities;

namespace $rootnamespace$
{
    public class $safeitemname$: EntityMap<$fileinputname$Entity>
	{
        public override void Map(EntityTypeBuilder<$fileinputname$Entity> builder)
        {
			base.Map(builder);

            builder.ToTable(nameof($fileinputname$Entity));
        }
    }
}