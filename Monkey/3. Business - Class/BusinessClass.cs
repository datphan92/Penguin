#region	License
//------------------------------------------------------------------------------------------------
// <License>
//     <Copyright> $year$ © $company$ </Copyright>
//     <Url> $companyurl$ </Url>
//     <Author> $username$ </Author>
//     <Project> $solutionname$ → Business Logic </Project>
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

using System.Threading.Tasks;
using $solutionname$.Data.Interfaces;
using Puppy.DependencyInjection.Attributes;

namespace $rootnamespace$
{
    [PerRequestDependency(ServiceType = typeof(I$safeitemname$))]
    public class $safeitemname$: I$safeitemname$
	{
		private readonly I$fileinputname$Repository _$fileinputname$Repository;

        public $safeitemname$(I$fileinputname$Repository $fileinputname$Repository)
        {
        	_$fileinputname$Repository = $fileinputname$Repository;
        }
    }
}