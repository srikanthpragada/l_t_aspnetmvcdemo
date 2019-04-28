using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Models
{
    public class StudentDAL
    {

        public static List<Student> GetStudents()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students", con);
            SqlDataReader dr = cmd.ExecuteReader();
            var students = new List<Student>();

            while (dr.Read())
            {
                students.Add(new Student
                {
                    Id = dr["StudentID"].ToString(),
                    Name = dr["Fullname"].ToString(),
                    Email = dr["Email"].ToString(),
                    Course = Int32.Parse(dr["Course"].ToString())
                }
                );
            }

            dr.Close();
            con.Close();
            return students;
        }


        public static List<Student> SearchStudents(string name)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("select * from students where fullname like @name", con);
            cmd.Parameters.AddWithValue("@name", "%" + name + "%");
            SqlDataReader dr = cmd.ExecuteReader();
            var students = new List<Student>();

            while (dr.Read())
            {
                students.Add(new Student
                {
                    Id = dr["StudentID"].ToString(),
                    Name = dr["Fullname"].ToString(),
                    Email = dr["Email"].ToString(),
                    Course = Int32.Parse(dr["Course"].ToString())
                }
                );
            }

            dr.Close();
            con.Close();
            return students;
        }


        public static bool DeleteStudent(int Id)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            int count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete from students where studentid = @id", con);
                cmd.Parameters.AddWithValue("@id", Id);
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            con.Close();
            return count == 1;
        }


        public static bool AddStudent(Student s)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                con.Open();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into students values(@name,@email,@course)", con);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@course", s.Course);
                    count = cmd.ExecuteNonQuery();
                    return count == 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            
        }


        public static Student GetStudent(int Id)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from students where studentid = @id", con);
                cmd.Parameters.AddWithValue("@id", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    var s = new Student
                    {
                        Id = dr["StudentID"].ToString(),
                        Name = dr["Fullname"].ToString(),
                        Email = dr["Email"].ToString(),
                        Course = Int32.Parse(dr["Course"].ToString())
                    };

                    return s;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}