using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Core.Models;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class CategoryRepository : EntityRepository<Category>
    {
        public CategoryRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        {
            //this.enableAsNoTracking = false;
        }

        protected override Category GenerateNewKey(Category contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Category> QueryRecords(IQueryable<Category> query, SearchInput searchQuery = null)
        {
            Expression<Func<Category, bool>> condition = null;
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

        protected override IOrderedQueryable<Category> SortRecords(IQueryable<Category> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Category> orderInterface = null;
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
            List<GenericListString> contents = ((ApplicationContext)context).Category.OrderBy(l => l.Name).ToList()
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

        #region CRUD_Method_Test_Functions
        public Category CreateCategory(Category category)
        {
            return Create(category);
        }

        public Category ReadCategory(string category)
        {
            return Read(category);
        }

        public Category UpdateCategory(Category category)
        {
            return Update(category);
        }

        public Category DeleteCategory(Category category)
        {
            return Delete(category);
        }

        public List<Category> ListCategories(SearchInput searchInput)
        {
            return List(searchInput);
        }

        public int ListCategoriesTotal(SearchInput searchInput)
        {
            return ListTotal(searchInput);
        }
        #endregion
    }
}
