﻿#region	License
//------------------------------------------------------------------------------------------------
// <License>
//     <Copyright> $year$ © $company$ </Copyright>
//     <Url> $companyurl$ </Url>
//     <Author> $username$ </Author>
//     <Project> $solutionname$ → Entity Map </Project>
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