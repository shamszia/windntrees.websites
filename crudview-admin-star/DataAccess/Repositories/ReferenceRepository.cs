using DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class ReferenceRepository : EntityRepository<Reference>
    {
        public ReferenceRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false) 
            : base(dbContext, relatedObjects)
        { }

        protected override Reference GenerateNewKey(Reference contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Reference> QueryRecords(IQueryable<Reference> query, SearchInput searchQuery = null)
        {
            Expression<Func<Reference, bool>> condition = null;
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
                        condition = l => (l.ReferenceId == key);
                        query = query.Where(condition);
                    }
                }

                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Name.Contains(searchQuery.keyword) || l.Description.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<Reference> SortRecords(IQueryable<Reference> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Reference> orderInterface = null;
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

        protected override Reference PostCreate(Reference contentObject)
        {
            contentObject.ContentBytes = null;
            return contentObject;
        }

        protected override Reference PostRead(Reference contentObject)
        {
            contentObject.ContentBytes = null;
            return contentObject;
        }

        protected override List<Reference> PostList(List<Reference> contentsList)
        {
            foreach (var content in contentsList)
            {
                content.ContentBytes = null;
            }

            return contentsList;
        }

        protected override Reference PostUpdate(Reference contentObject)
        {
            contentObject.ContentBytes = null;
            return contentObject;
        }

        protected override Reference PostDelete(Reference contentObject)
        {
            contentObject.ContentBytes = null;
            return contentObject;
        }
    }
}
