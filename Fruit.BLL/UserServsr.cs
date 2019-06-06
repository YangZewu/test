using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Fruit.DAL;
using Fruit.Model;
namespace Fruit.BLL
{
   public class UserServsr
    {
        private UserDAL user = new UserDAL();
        public List<userTable> GetList(Expression<Func<userTable, bool>> whereLambda)
        {
            return user.GetList(whereLambda);
        }
        //增加
        public bool Add(userTable u)
        {
            return user.Add(u);
        }
        //更新
        public bool Updata(userTable u)
        {
            return user.Updata(u);
        }
        //删除
        public bool Delete(int id)
        {
            return user.Delete(id);
        }
    }
}
