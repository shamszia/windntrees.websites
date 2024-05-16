using DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class CompanyTypeRepository : EntityRepository<CompanyType>
    {
        public CompanyTypeRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        { }


        protected override CompanyType GenerateNewKey(CompanyType contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<CompanyType> QueryRecords(IQueryable<CompanyType> query, SearchInput searchQuery = null)
        {
            Expression<Func<CompanyType, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Name.Contains(searchQuery.keyword) || l.Description.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<CompanyType> SortRecords(IQueryable<CompanyType> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<CompanyType> orderInterface = null;
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

        #region GetList()
        public GenericListString[] GetList()
        {
            List<GenericListString> contents = ((ApplicationContext)context).CompanyType.OrderBy(l => l.Name).ToList()
                    .Select(param =>
                    {
                        return new GenericListString
                        {
                            ItemText = param.Name,
                            ItemValue = param.Uid.ToString()
                        };
                    }).ToList();

            return contents.ToArray();
        }
        #endregion
    }
}
