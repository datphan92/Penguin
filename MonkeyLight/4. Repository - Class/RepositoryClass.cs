using $solutionname$.Data.Entities;
using $solutionname$.Data.Interfaces;
using Puppy.DependencyInjection.Attributes
using Puppy.EF;

namespace $rootnamespace$
{
    [PerRequestDependency(ServiceType = typeof(I$safeitemname$))]
    public class $safeitemname$: BaseEntityRepository<$fileinputname$Entity>, I$safeitemname$
	{
        public $safeitemname$(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}