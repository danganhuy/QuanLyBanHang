using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace QLBH.Classes
{
    internal class ConnectData
    {
        // đường dẫn kết nối tới cơ sở dữ liệu
        string strConnect = "Data Source=LAPTOP-LGFDQT7E\\MSSQLSERVER03;Initial Catalog=BTL_LTTQ_BanQuanAo;Integrated Security=True";
        SqlConnection sqlConn = null;
        //PT OpenConnect de mo ket noi
        void OpenConnect()
        {
            sqlConn = new SqlConnection(strConnect);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }
        //PT CloseConnect để đóng kết nối
        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
        //PT thực hiện truy vấn dữ liệu trả về DataTable su dung DataAdapter
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            CloseConnect();
            sqlData.Dispose();
            return dt;
        }
        //PT thực hiện thay đổi dữ liệu insert, update, delete dung SqlCommand
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
        public SqlDataReader ReaderLogin(string sqlSelect)
        {
            OpenConnect();
            SqlCommand sqlcommand = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader dt = sqlcommand.ExecuteReader();
            return dt;
            CloseConnect();
            sqlcommand.Dispose();
        }

    }
    class staticdata
    {
        public static string userName = "";
        public static string LinkAvt = "";
        public static string TenNV = "";
        public static string To;
    }
}
