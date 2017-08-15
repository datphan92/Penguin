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