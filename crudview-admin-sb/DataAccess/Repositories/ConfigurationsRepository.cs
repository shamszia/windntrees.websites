using DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class ConfigurationsRepository : EntityRepository<Configuration>
    {
        public ConfigurationsRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        { }

        protected override Configuration GenerateNewKey(Configuration contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Configuration> QueryRecords(IQueryable<Configuration> query, SearchInput searchQuery = null)
        {
            Expression<Func<Configuration, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.KeyParam.Contains(searchQuery.keyword) || l.ValParam.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<Configuration> SortRecords(IQueryable<Configuration> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Configuration> orderInterface = null;
            if (searchQuery != null)
            {
                if (searchQuery.descend == null ? false : ((bool)searchQuery.descend))
                {
                    orderInterface = query.OrderByDescending(l => l.KeyParam);
                }
                else
                {
                    orderInterface = query.OrderBy(l => l.KeyParam);
                }
            }
            return orderInterface;
        }

        #region GetKeyValue()
        public string GetKeyValue(string key)
        {
            var content = ((ApplicationContext)context).Configuration.Where(l => l.KeyParam == key).SingleOrDefault();
            if (content != null)
            {
                return content.ValParam;
            }
            return null;
        }
        #endregion

        #region GetList()
        public GenericListString[] GetList()
        {
            List<GenericListString> contents = ((ApplicationContext)context).Configuration.OrderBy(l => l.KeyParam).ToList()
                    .Select(param =>
                    {
                        return new GenericListString
                        {
                            ItemText = param.KeyParam,
                            ItemValue = param.ValParam
                        };
                    }).ToList();
            return null;
        }
        #endregion
    }
}
