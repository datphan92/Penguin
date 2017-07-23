#region	License
//------------------------------------------------------------------------------------------------
// <License>
//     <Copyright> $year$ © $company$ </Copyright>
//     <Url> $companyurl$ </Url>
//     <Author> $username$ </Author>
//     <Project> $solutionname$ → Service Facade </Project>
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

using Puppy.DependencyInjection.Attributes;
using $solutionname$.Business;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    [PerRequestDependency(ServiceType = typeof(I$safeitemname$))]
    public class $safeitemname$: I$safeitemname$
	{
        private readonly I$fileinputname$Business _$fileinputname$Business;
        public $safeitemname$(I$fileinputname$Business $fileinputname$Business)
        {
            _$fileinputname$Business = $fileinputname$Business;
        }
    }
}