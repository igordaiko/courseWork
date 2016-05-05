using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace City_Go.DataBase
{
    public class WorkWithDataBase
    {
        SqlDataAdapter adapter;
        DataSet set;
        string con;
        ITable table;
        public WorkWithDataBase(ITable table)
        {
            con = DataBaseInfo.GetDataBaseConnectionString();
            this.adapter = table.Adapter;
            this.table = table;
            set = new DataSet();
            adapter.Fill(set);
        }

        public DataTable SelectAllRows()
        {
            DataTable result = set.Tables[0].Clone();
            foreach (DataRow row in set.Tables[0].Rows)
            {
                result.ImportRow(row);
            }
            return result;
        }
        public DataTable SelectRowsByFilter(string filter)
        {
            DataTable result = set.Tables[0].Clone();
            foreach(DataRow row in set.Tables[0].Rows)
            {
                if (row[3].ToString().Contains(filter))
                    result.ImportRow(row);
            }
            return result;
        }
    }
}