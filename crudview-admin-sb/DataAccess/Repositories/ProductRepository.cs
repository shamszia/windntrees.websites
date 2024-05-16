using DataAccess.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Linq.Expressions;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;
using System.Collections.Generic;

namespace DataAccess.Core.Repositories
{
    public class ProductRepository : EntityRepository<Product>
    {
        private IConfiguration Configuration { get; set; }

        public ProductRepository(ApplicationContext dbContext, string relatedObjects = "", bool enableLazyLoading = false, IConfiguration configuration = null)
            : base(dbContext, relatedObjects)
        {
            Configuration = configuration;
        }

        protected override Product GenerateNewKey(Product contentObject)
        {
            contentObject.Uid = Guid.NewGuid();
            return contentObject;
        }

        protected override object GetTypedKey(object key)
        {
            return Guid.Parse((string)key);
        }

        protected override IQueryable<Product> QueryRecords(IQueryable<Product> query, SearchInput searchQuery = null)
        {
            Expression<Func<Product, bool>> condition = null;
            if (searchQuery != null)
            {
                if (!string.IsNullOrEmpty(searchQuery.key))
                {
                    condition = l => (l.Manufacturer == searchQuery.key);
                    query = query.Where(condition);
                }

                if (!string.IsNullOrEmpty(searchQuery.keyword))
                {
                    condition = l => (l.Name.Contains(searchQuery.keyword) || l.Description.Contains(searchQuery.keyword) || l.Color.Contains(searchQuery.keyword));
                    query = query.Where(condition);
                }
            }
            return query;
        }

        protected override IOrderedQueryable<Product> SortRecords(IQueryable<Product> query, SearchInput searchQuery = null)
        {
            IOrderedQueryable<Product> orderInterface = null;
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

        public Product GetProductByID(string id)
        {
            Guid uid = Guid.Parse(id);
            using (ApplicationContext dbContext = new ApplicationContext())
            {
                var product = dbContext.Product.Where(l => l.Uid == uid).SingleOrDefault();
                return product;
            }
        }

        public Product GetProductByName(string name)
        {
            using (ApplicationContext dbContext = new ApplicationContext())
            {
                var product = dbContext.Product.Where(l => l.Name == name).FirstOrDefault();
                return product;
            }
        }

        public DashboardReport GetDashboardReport(SearchInput searchQuery) {

            return new DashboardReport {
                Products = 10,
                Sales = 30000,
                Discount = 500,
                ReceivedPayment = 24000,
                DuePayment = 5500
            };
        }

        public List<OptionItem> GetMonthlyChartSummary(WindnTrees.ICRUDS.Standard.SearchInput searchInput)
        {
            List<OptionItem> contents = new List<OptionItem>();
            
            contents.Add(new OptionItem { key = "01", val = "10000" });
            contents.Add(new OptionItem { key = "02", val = "20000" });
            contents.Add(new OptionItem { key = "03", val = "30000" });
            contents.Add(new OptionItem { key = "04", val = "40000" });
            contents.Add(new OptionItem { key = "05", val = "30000" });
            contents.Add(new OptionItem { key = "06", val = "20000" });
            contents.Add(new OptionItem { key = "07", val = "20000" });
            contents.Add(new OptionItem { key = "08", val = "30000" });

            return contents;
        }
    }
}
