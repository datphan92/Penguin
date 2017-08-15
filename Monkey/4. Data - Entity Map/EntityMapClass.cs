#region	License
//------------------------------------------------------------------------------------------------
// <License>
//     <Copyright> $year$ © $company$ </Copyright>
//     <Url> $companyurl$ </Url>
//     <Author> $username$ </Author>
//     <Project> $solutionname$ → Repository </Project>
//     <File>
//         <Name> $safeitemname$.cs </Name>
//         <Created> $time$ </Created>
//         <Key> $guid10$ </Key>
//     </File>
//     <Summary>
//         $safeitemname$.cs
//     </Summary>
// <License>
//------------------------------------------------------------------------------------------------
#endregion License

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