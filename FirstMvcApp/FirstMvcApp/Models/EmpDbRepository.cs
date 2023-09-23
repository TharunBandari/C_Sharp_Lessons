using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FirstMvcApp.Models
{
    public class EmpDbRepository
    {
        public static List<Emp> GetEmpList()
        {
            List<Emp> emplist = new List<Emp>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl_Tharun";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Emp emp = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)


                    };
                    emplist.Add(emp);
                }
                return emplist;
            }
        }
        public static Emp GetEmpById(int id)
        {
            Emp empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl_Tharun Where eno=@id";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        City = empdr.GetString(3),
                        Salary = (int)empdr.GetDecimal(2)
                        
                    };
                }
            }
            return empFound;
        }
        /*public static int AddNewEmp(Emp newEmp)
        {


        }

        public static int UpdateEmp(EmpDbRepository modifiedemp)
        {

        }
        public static int DeleteEmp(int id)
        {

        }*/
    }
}
