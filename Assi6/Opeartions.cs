using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assi6
{
    public class Opeartions
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Opeartions()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=Assi6;Integrated Security=True;Pooling=False;pooling=false";
            cmd.Connection = con;

        }

        public SqlConnection Getcon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void insertdept(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public DataSet exedataset(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void insertdesig(string sql)
        {
            Getcon();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public DataSet showGrid(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void updategrid(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void deleteGrid(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}