using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Core.Models;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace DataAccess.Core.Repositories
{
    public class ColorEmptyRepository : EntityEmptyRepository<Color>
    {
        public ColorEmptyRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false)
            : base(dbContext, relatedObjects)
        { }

        protected override Color GenerateNewKey(Color contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Color> QueryRecords(IQueryable<Color> query, SearchInput searchQuery = null)
        {
            Expression<Func<Color, bool>> condition = null;
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

        protected override IOrderedQueryable<Color> SortRecords(IQueryable<Color> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Color> orderInterface = null;
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
            List<GenericListString> contents = ((ApplicationContext)context).Colors.OrderBy(l => l.Name).ToList()
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

        protected override Color GetContentForCreate()
        {
            return new Color
            {
                Uid = Guid.NewGuid(),
                Name = string.Format("{0}{1}","C", DateTime.Now.ToString("ddHHmmss")),
                Description = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
        }

        protected override string GetIdForRead()
        {
            var color = new ApplicationContext().Colors.OrderByDescending(l => l.Description).FirstOrDefault();
            return color.Uid.ToString();
        }

        protected override Color GetContentForUpdate()
        {
            var color = new ApplicationContext().Colors.OrderByDescending(l => l.Description).FirstOrDefault();
            color.Name = string.Format("{0}{1}", "C", DateTime.Now.ToString("ddHHmmss"));
            return color;
            //return new Color { Uid = color.Uid, Name = color.Name, Description = color.Description };
        }

        protected override Color GetContentForDelete()
        {
            var color = new ApplicationContext().Colors.OrderByDescending(l => l.Description).FirstOrDefault();
            return color;
            //return new Color { Uid = color.Uid, Name = color.Name, Description = color.Description };
        }

        protected override SearchInput GetConditionsForListing()
        {
            return new SearchInput
            {
                keyword = ""
            };
        }

        //repository target (CRUDMethod)

        public Color CreateCRUD()
        {
            return base.Create();
        }

        public Color ReadCRUD()
        {
            return base.Read();
        }

        public Color UpdateCRUD()
        {
            return base.Update();
        }

        public Color DeleteCRUD()
        {
            return base.Delete();
        }

        public List<Color> ListCRUD()
        {
            return base.List();
        }

        public int ListCRUDTotal()
        {
            return base.ListTotal();
        }
    }
}
