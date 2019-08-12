using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace 宿舍管理系统
{
    class sqlconnection1
    {
        private string conn = "Data Source=DESKTOP-MQBK3FK\\SQLEXPRESS;Initial Catalog=Manager;Integrated Security=True";
        public SqlConnection con;

        public sqlconnection1()
        {
           
        }

        public void connection()
        {
            con = new SqlConnection(conn);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
            }
        }

        public void close()
        {
            con.Close();
        }

        public ArrayList getdatastudent(sqlconnection1 conn, int data)
        {
            ArrayList alist = new ArrayList();
            string constr = "select snumber from student where sout='" + data + "'";
            SqlCommand comm = new SqlCommand(constr, conn.con);
            try
            {
                SqlDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    alist.Add((string)read["snumber"].ToString());
                    alist[0] = 1;
                }
                read.Close();
                conn.close();
                return alist;
            }
            catch (Exception ex)
            {
                alist.Clear();
                alist.Add(0);
                return alist;
            }
        }

        public ArrayList getsbedstudent()
        {
            connection();
            ArrayList alist = new ArrayList();
            string constr = "select snumber from student where sbed='0'";
            SqlCommand comm = new SqlCommand(constr, con);
            try
            {
                SqlDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    alist.Add((string)read["snumber"].ToString());
                }
                read.Close();
                con.Close();
                return alist;
            }
            catch (Exception ex)
            {
                alist.Clear();
                alist.Add(0);
                return alist;
            }
        }
    }
}
