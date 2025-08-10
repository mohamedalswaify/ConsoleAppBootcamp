using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.Connect_DB
{
    internal class Connect
    {

        static void Main()
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter Department ID:");
            int emp_id = Convert.ToInt32(Console.ReadLine());
   
         string connectionString = "Server=DESKTOP-L71NKL9\\MSSQLSERVERR;Database=HR;User Id=sa;Password=123;";

         string query = $"select employee_Id,Last_name,salary from Employees where department_id ={emp_id}";


            using(SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
             SqlDataReader reader=   cmd.ExecuteReader();


                
                while (reader.Read())
                {
                    employees.Add(new Employee

                    {
                        Id = Convert.ToInt32(reader["employee_Id"]),
                        Name = Convert.ToString(reader["Last_name"]),
                        salary = Convert.ToDouble(reader["Salary"])
                    }
                );
                   
                }


                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp);
                }





                conn.Close();



            }




            Console.ReadKey();
        }



    }
}
