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

using $solutionname$.Data.Entities;
using $solutionname$.Data.Interfaces;
using Puppy.DependencyInjection.Attributes;

namespace $rootnamespace$
{
    [PerRequestDependency(ServiceType = typeof(I$safeitemname$))]
    public class $safeitemname$: EntityRepository<$fileinputname$Entity>, I$safeitemname$
	{
        public $safeitemname$(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}