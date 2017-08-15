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