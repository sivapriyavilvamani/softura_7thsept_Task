using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace ConsoleApp2
{
    internal class Dataaa
    {   
        public void getdata()
        {
            SqlConnection con = new SqlConnection("Data source =DESKTOP-S37P10C ; database=Test; user id=sa; password=p@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentdata",con);
           SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader[0].ToString()+"\t"+reader[1].ToString()+"\t"+reader[2].ToString());
            }
              
        }
        public void insData(string pname, string DOB, string DOJ, string place)
        {
            SqlConnection con = new SqlConnection("Data source =DESKTOP-S37P10C; initial catalog=test;integrated security=true");
            SqlCommand cmd = new SqlCommand("inshdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", SqlDbType.NVarChar).Value= pname;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value=  DOB;
            cmd.Parameters.AddWithValue("@DOJ", SqlDbType.Date).Value=  DOJ;
            cmd.Parameters.AddWithValue("@place", SqlDbType.NVarChar).Value= place;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");
        }
        //public void insdaata(string name,DateTime date, string DOJ, string place)
        //{
            
        //    SqlConnection con = new SqlConnection("Data source =DESKTOP-S37P10C; initial catalog=test;integrated security=true");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("inshdata", con);

        //    cmd.Parameters.AddWithValue("@pname", SqlDbType.NVarChar).Value=name;
        //    cmd.Parameters.AddWithValue("@DOB",SqlDbType.Date).Value=date;
        //    cmd.Parameters.AddWithValue("@DOJ", SqlDbType.NVarChar).Value=DOJ;
        //    cmd.Parameters.AddWithValue("@place",SqlDbType.NVarChar).Value= place;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    Console.WriteLine("Inserted");
        //}
        public static void Main()
        {
            Dataaa dataaa = new Dataaa();
            dataaa.getdata();
            dataaa.insData("priya", "10/12/2000", "12/10/2021", "chennai");
           
        }
    }
}
