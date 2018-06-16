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
    public class kargah_letter : DataAccessLayers   //use dataAccessLayers class in this class
    {
        public string klid, kid_fk, pid_fk, klnoedarkhast, klvaziyat;

        public void add()
        {
            base.connection();  //use base to use dataAccessLayer aclss objects
            string sql = "insert into Kargah_letter (klid, kid_fk, pid_fk, klnoedarkhast, klvaziyat) values ({0}, {1}, {2}, N'{3}')";
            sql = string.Format(sql, klid, kid_fk, pid_fk, klnoedarkhast, klvaziyat);    // set values to DB
            base.docommand(sql);
            base.disconnect();
        }
    }
}
