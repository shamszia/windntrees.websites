using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Core.Models;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class AdvertisementRepository : EntityRepository<Advertisement>
    {
        public AdvertisementRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false) 
            : base(dbContext, relatedObjects)
        { }

        protected override Advertisement GenerateNewKey(Advertisement contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Advertisement> QueryRecords(IQueryable<Advertisement> query, SearchInput searchQuery = null)
        {
            Expression<Func<Advertisement, bool>> condition = null;
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

                if (searchQuery.keywords != null)
                {
                    var keywords = (List<SearchField>) searchQuery.keywords;
                    var location = keywords.Where(l => l.field == "Location").SingleOrDefault();

                    if (location != null)
                    {
                        condition = l => (l.Location.Contains(location.value));
                        query = query.Where(condition);
                    }

                    var page = keywords.Where(l => l.field == "Page").SingleOrDefault();
                    if (page != null)
                    {
                        condition = l => (l.Page.Contains(page.value));
                        query = query.Where(condition);
                    }

                    var news = keywords.Where(l => l.field == "News").SingleOrDefault();
                    if (news != null)
                    {
                        bool isNews = Boolean.Parse(news.value);

                        condition = l => (l.News == isNews);
                        query = query.Where(condition);
                    }
                }

                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Heading.Contains(searchQuery.keyword) || l.SubHeading.Contains(searchQuery.keyword) || l.Detail.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }

            return query;
        }

        protected override IOrderedQueryable<Advertisement> SortRecords(IQueryable<Advertisement> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Advertisement> orderInterface = null;
            if (searchQuery != null)
            {
                if (searchQuery.descend == null ? false : ((bool)searchQuery.descend))
                {
                    orderInterface = query.OrderByDescending(l => l.SortOrder).ThenBy(l=>l.Heading);
                }
                else
                {
                    orderInterface = query.OrderBy(l => l.SortOrder).ThenBy(l => l.Heading);
                }
            }
            return orderInterface;
        }
    }
}
