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
    public class visit : DataAccessLayers  //use dataAccessLayers class in this class
    {
        public string vid, vdate, vnextdate, kid_fk;

        public void add()
        {
            base.connection();  //use base to use dataAccessLayer aclss objects
            string sql = "insert into Visit (vid, vdate, vnextdate, kid_fk) values ({0}, N'{1}', N'{2}', {3})";
            sql = string.Format(sql, vid, vdate, vnextdate, kid_fk);    // set values to DB
            base.docommand(sql);
            base.disconnect();
        }
    }
}
