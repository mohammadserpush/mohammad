using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DA;
using BL;

namespace BL
{
    public class kargah : DataAccessLayers //use dataAccessLayers class in this class
    {
        public string kid, kname, kaddr, pid_fk, kworkercount, ktell, ktype;

        public void add()
        {
            base.connection();  //use base to use dataAccessLayer aclss objects
            string sql = "insert into Kargah (kid, kname, kaddr, pid_fk, kworkercount, ktell, ktype) values ({0}, N'{1}', N'{2}', {3}, {4}, N'{5}', N'{6}')";
            sql = string.Format(sql, kid, kname, kaddr, pid_fk, kworkercount, ktell, ktype);    // set values to DB
            base.docommand(sql);
            base.disconnect();
        }
    }
}
