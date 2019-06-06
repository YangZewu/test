using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Fruit.Model;
namespace Fruit.DAL
{
    public class UserDAL
    {
        private FruitEntities fruit = new FruitEntities();
        public List<userTable> GetList(Expression<Func<userTable, bool>> whereLambda)
        {
            return fruit.userTable.Where(whereLambda).ToList();
        }
        //增加
        public bool Add(userTable u)
        {
            fruit.userTable.Add(u);
            return fruit.SaveChanges() > 0;
        }
        //更新
        public bool Updata(userTable u)
        {
            var us = fruit.userTable.Where(a => a.userName == u.userName).FirstOrDefault();
            us.userPwd = u.userPwd;
            return fruit.SaveChanges() > 0;
        }
        //删除
        public bool Delete(int id)
        {
            var us = new userTable { userId = id };
            fruit.userTable.Attach(us);
            fruit.userTable.Remove(us);
            return fruit.SaveChanges() > 0;
        }
    }
}
