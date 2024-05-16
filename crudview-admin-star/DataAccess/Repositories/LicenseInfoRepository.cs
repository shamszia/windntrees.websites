using DataAccess.Core.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class LicenseInfoRepository : EntityRepository<LicenseInfo>
    {
        public LicenseInfoRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false) 
            : base(dbContext, relatedObjects)
        { }

        protected override IQueryable<LicenseInfo> QueryRecords(IQueryable<LicenseInfo> query, SearchInput searchQuery = null)
        {
            Expression<Func<LicenseInfo, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.key))
                {
                    Nullable<Guid> key = null;
                    try
                    {
                        key = Guid.Parse(searchQuery.key);
                    }
                    catch { }

                    if (key != null)
                    {
                        condition = l => (l.ProductId == key);
                        query = query.Where(condition);
                    }
                }
            }
            return query;
        }

        protected override IOrderedQueryable<LicenseInfo> SortRecords(IQueryable<LicenseInfo> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<LicenseInfo> orderInterface = null;
            if (searchQuery != null)
            {
                if (searchQuery.descend == null ? false : ((bool)searchQuery.descend))
                {
                    orderInterface = query.OrderByDescending(l => l.Code);
                }
                else
                {
                    orderInterface = query.OrderBy(l => l.Code);
                }
            }
            return orderInterface;
        }
    }
}
