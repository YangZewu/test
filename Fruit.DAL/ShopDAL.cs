using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Fruit.Model;
namespace Fruit.DAL
{
   public class ShopDAL
    {
        private FruitEntities fruit = new FruitEntities();
        public List<Shopping> GetLists(Expression<Func<Shopping, bool>> whereLambda)
        {
            return fruit.Shopping.Where(whereLambda).ToList();
        }
        public List<Shopping> GetListsByPage(int offset, int limit, Expression<Func<Shopping, bool>> whereLambda)
        {
            return fruit.Shopping.OrderBy(a => a.shoppingId).Skip(offset).Take(limit).ToList();
        }
    }
}
