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