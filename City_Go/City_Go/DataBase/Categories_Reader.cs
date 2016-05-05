﻿using System;
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
    public class Categories_Reader : ITable
    {
        public SqlDataAdapter adapter;
        SqlCommand command;
        SqlConnection connection;
        DataSet set;
        string query, con;
        public Categories_Reader()
        {
            query = "Select * from Categories";
            command = new SqlCommand(query);
            con = DataBaseInfo.GetDataBaseConnectionString();
            connection = new SqlConnection(con);
            adapter = new SqlDataAdapter(query, connection);
            Adapter = adapter;
            queryUpdate = "Update Categories set [name] = @p2, [img] = @p3, [parentID] = @p4, [companyID] = @p5" +
                " where [id] = @p1";
        }
        public SqlDataAdapter Adapter { get; set; }
        public string queryUpdate { get; set; }

    }
}