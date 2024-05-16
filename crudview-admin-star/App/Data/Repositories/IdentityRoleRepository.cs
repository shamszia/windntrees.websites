using Application.Core.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class IdentityRoleRepository : EntityRepository<IdentityRole>
    {
        public IdentityRoleRepository(ApplicationDbContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        {   
            
        }

        protected override IQueryable<IdentityRole> QueryRecords(IQueryable<IdentityRole> query, SearchInput searchQuery = null)
        {
            Expression<Func<IdentityRole, bool>> condition = null;
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

        protected override IOrderedQueryable<IdentityRole> SortRecords(IQueryable<IdentityRole> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<IdentityRole> orderInterface = null;
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
                IQueryable<IdentityRole> query = entitySet;
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
