using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Fruit.DAL;
using Fruit.Model;
namespace Fruit.BLL
{
    public class ShopServer
    {
        private ShopDAL shop = new ShopDAL();
        public List<Shopping> GetListsByPage(int offset, int limit, Expression<Func<Shopping, bool>> whereLambda)
        {
            return shop.GetListsByPage(offset, limit, whereLambda);
        }
        public int GetCount(Expression<Func<Shopping, bool>> whereLambda)
        {
            return shop.GetLists(whereLambda).Count;
        }
    }
}
