using Application.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace Application.Core.Data
{
    public class ApplicationUserRepository : EntityRepository<ApplicationUser>
    {
        public ApplicationUserRepository(ApplicationDbContext dbContext, string relatedObjects = "Roles", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        { }

        protected override IQueryable<ApplicationUser> QueryRecords(IQueryable<ApplicationUser> query, SearchInput searchQuery = null)
        {
            Expression<Func<ApplicationUser, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Id.Contains(searchQuery.keyword) || l.UserName.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<ApplicationUser> SortRecords(IQueryable<ApplicationUser> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<ApplicationUser> orderInterface = null;
            if (searchQuery != null)
            {
                if (searchQuery.descend == null ? false : ((bool) searchQuery.descend))
                {
                    orderInterface = query.OrderByDescending(l => l.CreationDate);
                }
                else
                {
                    orderInterface = query.OrderBy(l => l.CreationDate);
                }
            }
            return orderInterface;
        }

        protected override List<ApplicationUser> PostList(List<ApplicationUser> contentsList)
        {
            if (contentsList != null) {
                foreach(var user in contentsList) {
                    if (user.Roles != null) {

                        foreach (var role in user.Roles) {
                            role.UserId = null;
                        }
                    }
                }
            }

            return contentsList;
        }

        public ApplicationUser GetByName(string name)
        {
            ApplicationUser result = PostRead(entitySet.Where(l => l.UserName == name).SingleOrDefault());
            return result;
        }
    }
}
