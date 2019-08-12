using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
namespace 宿舍管理系统
{
    class sushe
    {
        private int id;
        private int door;
        private int fan;
        private int window;
        private int air;
        private int light;
        private int heat;
        private int bed1;
        private int bed2;
        private int bed3;
        private int bed4;
        private int amount;

        /**
         * @roseuid 5C285DB6004E
         */
        public sushe(int a)
        {
            id = a;
        }
        /**
         * @return int
         * @roseuid 5C285B3C004A
         */
        public bool setBed(sqlconnection1 conn,int number,int bed,int snumber)
        {
            string constr;
            string constr1;
            switch (bed)
            {
                case 1:
                    constr = "update sushe set bed1='" + snumber + "' where id='" + number + "'";
                    break;
                case 2:
                    constr = "update sushe set bed2='" + snumber + "' where id='" + number + "'";
                    break;
                case 3:
                    constr = "update sushe set bed3='" + snumber + "' where id='" + number + "'";
                    break;
                case 4:
                    constr = "update sushe set bed4='" + snumber + "' where id='" + number + "'";
                    break;
                default:
                    return false ;
            }
            conn.connection();
            SqlCommand comm = new SqlCommand(constr, conn.con);
            try
            {
                if (comm.ExecuteNonQuery() > 0)
                {
                    conn.close();
                }
                else
                {
                    conn.close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false ;
            }
            constr1 = "update student set sbed='" + bed+ "',s#='"+number+"' where snumber='" + snumber + "'";
            conn.connection();
            SqlCommand comm1 = new SqlCommand(constr1, conn.con);
            try
            {
                if (comm1.ExecuteNonQuery() > 0)
                {
                    conn.close();
                    return true;
                }
                else
                {
                    conn.close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false ;
            }
        }

        /**
         * @return int
         * @roseuid 5C285B420017
         */
        public int getAmount(sqlconnection1 conn, int number)
        {
            string constr = "select amount from sushe where id='"+number+"'";
            conn.connection();
            SqlCommand comm = new SqlCommand(constr, conn.con);
            try
            {
                SqlDataReader read = comm.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    int a = (int)read["amount"];
                    read.Close();
                    conn.close();
                    return a;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /**
         * @return int
         * @roseuid 5C285B4D0025
         */
        public bool setAmount(sqlconnection1 conn,int number)
        {
            int n=getAmount(conn,number)+1;
            string constr = "update sushe set amount='"+n+"' where id='"+number+"'";
            conn.connection();
            SqlCommand comm = new SqlCommand(constr, conn.con);
            try
            {
                if (comm.ExecuteNonQuery() > 0)
                {
                    conn.close();
                    return true;
                }
                else
                {
                    conn.close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false ;
            }
        }

        public String getsex(sqlconnection1 conn)
        {
            conn.connection();
            string constr = "select sex from sushe where id='"+id+"'";
            SqlCommand comm = new SqlCommand(constr,conn.con);
            try
            {
                SqlDataReader read = comm.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    return (string)read["sex"].ToString().Trim();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
