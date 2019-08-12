using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace 宿舍管理系统
{
    class student
    {
   private string sname;
   private int snumber;
   private string spassword;
   private int sage;
   private int sin;
   private int sout;
   private int ssushe;
   private int sbed;
   private string szhuanye;
   private int sclass;
   
   /**
    * @roseuid 5C285A090049
    */
   public student(int a) 
   {
       snumber = a;
   }
   
   /**
    * @return int
    * @roseuid 5C2859520127
    */
   public bool applySushe(sqlconnection1 conn, string a) 
   {
       conn.connection();
       string constr = "update student set ssushe='" + a + "' where snumber='" + snumber + "'";
       SqlCommand comm = new SqlCommand(constr, conn.con);
       try
       {
           if (comm.ExecuteNonQuery() > 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       catch (Exception ex)
       {
           return false;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28595B0253
    */
   public bool alterPsw(sqlconnection1 conn,string passwords) 
   {
       conn.connection();
       string constr="update student set spasswords='"+passwords+"' where snumber='"+snumber+"'";
       SqlCommand comm=new SqlCommand(constr,conn.con);
       try
       {
           if(comm.ExecuteNonQuery()>0)
           {
               conn.close();
               return true;
           }
           else
           {
               return false;
           }
       }
       catch(Exception ex)
       {
           return false;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C2859610376
    */
   public ArrayList getMessage(sqlconnection1 conn) 
   {
       ArrayList alist = new ArrayList();
       conn.connection();
       string constr = "select * from student where snumber='"+snumber+"'";
       SqlCommand comm = new SqlCommand(constr,conn.con);
       try
       {
           SqlDataReader read = comm.ExecuteReader();
           read.Read();
           if (read.HasRows)
           {
               for (int i = 0; i < 11; i++)
                   alist.Add(read.GetValue(i));
           }
           else
           {
               for (int i = 0; i < 11; i++)
                   alist.Add("获取失败！");
           }
           read.Close();
           conn.close();
       }
       catch (Exception ex)
       {
           for (int i = 0; i < 12; i++)
               alist.Add("获取失败！");
           return alist;
       }
       conn.connection();
       string constr1 = "select et from sushe where id='" + alist[6] + "'";
       SqlCommand comm1 = new SqlCommand(constr1, conn.con);
       try
       {
           SqlDataReader read1 = comm1.ExecuteReader();
           read1.Read();
           if (read1.HasRows)
           {
               alist.Add(read1["et"]);
           }
           else
           {
               alist.Add("获取失败！");
           }
           read1.Close();
           conn.close();
           return alist;
       }
       catch (Exception ex)
       {
           alist.Add("获取失败！");
           return alist;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28596C02C1
    */
   public bool applyEtmsg(sqlconnection1 conn, string a) 
   {
       conn.connection();
       string constr = "update student set smessage='"+a+"' where snumber='"+snumber+"'";
       SqlCommand comm = new SqlCommand(constr, conn.con);
       try
       {
           if (comm.ExecuteNonQuery() > 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }catch(Exception ex)
       {
           return false;
       }
   }

    }
}
