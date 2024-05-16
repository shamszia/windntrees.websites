using Application.Core.Data;
using Application.Core.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class ApplicationRoleRepository : EntityRepository<ApplicationRole>
    {
        public ApplicationRoleRepository(ApplicationDbContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        {   
            
        }

        protected override IQueryable<ApplicationRole> QueryRecords(IQueryable<ApplicationRole> query, SearchInput searchQuery = null)
        {
            Expression<Func<ApplicationRole, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Id.Contains(searchQuery.keyword) || l.Name.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<ApplicationRole> SortRecords(IQueryable<ApplicationRole> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<ApplicationRole> orderInterface = null;
            if (searchQuery != null)
            {
                if (searchQuery.descend == null ? false : ((bool)searchQuery.descend))
                {
                    orderInterface = query.OrderByDescending(l => l.Name);
                }
                else
                {
                    orderInterface = query.OrderBy(l => l.Name);
                }
            }
            return orderInterface;
        }

        public virtual Array GetAllRoles()
        {
            try
            {
                IQueryable<ApplicationRole> query = entitySet;
                return query.OrderBy(q => q.Id).
                    Select(c => new
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToArray();
            }
            catch
            {
                throw;
            }
        }
    }
}
