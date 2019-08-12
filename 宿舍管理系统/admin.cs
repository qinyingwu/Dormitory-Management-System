using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;


namespace 宿舍管理系统
{
    class admin
    {
   private String name;
   private String number;
   private String sex;
   private String passwords;
   
   /**
    * @roseuid 5C2858340263
    */
   public admin(string a) 
   {
       number = a;
   }
   
   /**
    * @return String
    * @roseuid 5C285732006E
    */
   public bool setsmessage(sqlconnection1 conn, int snumber) 
   {
       conn.connection();
       string constr = "update student set smessage='0' where snumber='" + snumber + "'";
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
           return false;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28573E0342
    */
   public bool setssushe(sqlconnection1 conn,int snumber) 
   {
       conn.connection();
       string constr = "update student set ssushe='0' where snumber='"+snumber+"'";
       SqlCommand comm = new SqlCommand(constr,conn.con);
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
           return false;
       }

   }
   
   /**
    * @return String
    * @roseuid 5C285747014A
    */
   public ArrayList getssushe(sqlconnection1 conn) 
   {
       ArrayList alist = new ArrayList();
       conn.connection();
       string constr = "select sname,snumber,ssushe from student";
       SqlCommand comm = new SqlCommand(constr, conn.con);
       try
       {
           SqlDataReader read = comm.ExecuteReader();
           while (read.Read())
           {
               if (read["ssushe"].ToString() != "0")
               {
                   alist.Add(read["snumber"]);
                   alist.Add(read["sname"]);
                   alist.Add(read["ssushe"]);
               }
           }
           read.Close();
           conn.close();
           return alist;
       }
       catch (Exception ex)
       {
           alist.Clear();
           alist.Add("出现错误！");
           return alist;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28574B0133
    */
   public ArrayList getsmessage(sqlconnection1 conn) 
   {
       ArrayList alist = new ArrayList();
       conn.connection();
       string constr = "select sname,snumber,smessage from student";
       SqlCommand comm = new SqlCommand(constr,conn.con);
       try
       {
           SqlDataReader read = comm.ExecuteReader();
           while (read.Read())
           {
               if (read["smessage"].ToString()!= "0"  )
               {
                   alist.Add(read["snumber"]);
                   alist.Add(read["sname"]);
                   alist.Add(read["smessage"]);
               }
           }
           read.Close();
           conn.close();
           return alist;
       }
       catch (Exception ex)
       {
           alist.Clear();
           alist.Add("出现错误！");
           return alist;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28575302C1
    */
   public ArrayList getallbed(sqlconnection1 conn,int a) 
   {
           ArrayList alist = new ArrayList();
           conn.connection();
           string constr = "select * from sushe";
           SqlCommand comm = new SqlCommand(constr, conn.con);
           try
           {
               SqlDataReader read = comm.ExecuteReader();
               while (read.Read())
               {
                   if (a == 0)
                   {
                       alist.Add(read["id"]);
                       alist.Add(read["bed1"]);
                       alist.Add(read["bed2"]);
                       alist.Add(read["bed3"]);
                       alist.Add(read["bed4"]);
                   }
                   else
                   {
                       if (int.Parse(read["amount"].ToString())<4)
                       {
                           alist.Add(read["id"]);
                           alist.Add(read["bed1"]);
                           alist.Add(read["bed2"]);
                           alist.Add(read["bed3"]);
                           alist.Add(read["bed4"]);
                       }
                   }
               }
               read.Close();
               conn.close();
               return alist;
           }
           catch (Exception ex)
           {
               alist.Clear();
               alist.Add("没有空寝室！");
               return alist;
           }
   }
   
   /**
    * @return String
    * @roseuid 5C28575A0231
    */
   public bool addnewst(sqlconnection1 conn,int number,int bed,int snumber) 
   {
       bool b = false;
       student a = new student(snumber);
       sushe c = new sushe(number);
       if (a.getMessage(conn)[10].Equals(c.getsex(conn)))
           b = true;
       conn.close();
       if(b)
       {
           if (c.setBed(conn, number, bed, snumber))
           {
               if (c.setAmount(conn, number))
                   return true;
               else
                   return false;
           }
           else
           {
               return false;
           }
       }else
       {
           return false ;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C285760030C
    */
   public int deletegdu(sqlconnection1 conn,int data1,int data2,int number) 
   {
       if (number == 0)
       {
           if (data2 - data1 == 4)
           {
               ArrayList alist = conn.getdatastudent(conn, data2);
               if (alist[0].ToString() != "0")
               {
                   for (int i = 0; i < alist.Count; i++)
                   {
                       conn.connection();
                       string constr = "delete from student where snumber='"+int.Parse(alist[i].ToString())+"'";
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
                           }
                       }
                       catch (Exception ex)
                       {
                           return 0;
                       }
                   }
                   return 1;
               }
               else
               {
                   return 0;
               }
           }
           else
           {
               return 0;
           }
       }
       else
       {
           if (data1 <= data2)
           {
               for (int i = data1; i <= data2; i++)
               {
                   conn.connection();
                   string constr = "delete from student where snumber='" + i + "'";
                   SqlCommand comm = new SqlCommand(constr, conn.con);
                   try
                   {
                       if (comm.ExecuteNonQuery() > 0)
                       {
                           conn.close();
                       }
                       else
                       {
                           return i;
                       }
                   }
                   catch (Exception ex)
                   {
                       return 0;
                   }
               }
               return 1;
           }
           else
           {
               return 0;
           }
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28576A03E6
    */
   public ArrayList searchEtmsg(sqlconnection1 conn,int id) 
   {
       ArrayList alist = new ArrayList();
       string constr = "select * from sushe where id='"+id+"'";
       conn.connection();
       SqlCommand comm = new SqlCommand(constr,conn.con);
       try
       {
           SqlDataReader read = comm.ExecuteReader();
           read.Read();
           alist.Add(read["door"]);
           alist.Add(read["fan"]);
           alist.Add(read["window"]);
           alist.Add(read["air"]);
           alist.Add(read["light"]);
           alist.Add(read["heat"]);
           alist.Add(read["et"]);
           read.Close();
           conn.close();
           return alist;
       }
       catch (Exception ex)
       {
           alist.Clear();
           for (int i = 0; i < 7; i++)
               alist.Add("出现错误！");
           return alist;
       }
   }
   
   /**
    * @return String
    * @roseuid 5C28578600C4
    */
   public bool alterStmsg(sqlconnection1 conn,ArrayList alist) 
   {
       string constr = "update student set sname='" + alist[1].ToString() + "',sage='" + int.Parse(alist[2].ToString()) + "',sin='" + int.Parse(alist[3].ToString()) + "',sout='" + int.Parse(alist[4].ToString()) + "',szhuanye='" + (alist[5].ToString()) + "',class='" + int.Parse(alist[6].ToString()) + "',ssex='" + (alist[7].ToString()) + "' where snumber='"+int.Parse(alist[0].ToString())+"'";
       conn.connection();
       SqlCommand comm = new SqlCommand(constr,conn.con);
       try
       {
           if (comm.ExecuteNonQuery() > 0)
           {
               conn.close();
               return true;
           }
           else
           {
               conn.connection();
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
    * @roseuid 5C28579200EA
    */
   public bool alterPsw(sqlconnection1 conn, string passwords) 
   {
       conn.connection();
       string constr = "update admin set mpasswords='" + passwords + "' where mnumber='" + number + "'";
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
    * @roseuid 5C28579902CE
    */
   public bool alterEtmsg(sqlconnection1 conn, ArrayList alist) 
   {
       string constr = "update sushe set door='" + int.Parse(alist[1].ToString()) + "',fan='" + int.Parse(alist[2].ToString()) + "',window='" + int.Parse(alist[3].ToString()) + "',air='" + int.Parse(alist[4].ToString()) + "',light='" + int.Parse(alist[5].ToString()) + "',heat='" + int.Parse(alist[6].ToString()) + "',et='" + (alist[7].ToString()) + "' where id='" + int.Parse(alist[0].ToString()) + "'";
       conn.connection();
       SqlCommand comm = new SqlCommand(constr,conn.con);
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
           return false;
       }
   }

    }
}
