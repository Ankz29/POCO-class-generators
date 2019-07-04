using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO.Models;
using System.Data.SqlClient;
namespace POCO.Controllers
{
    public partial class Dept_TBController : Controller
    {
        //
        // GET: /Dept_TB/
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Index1(Dept_TB model)
        {
            string connection = ConfigurationManager.ConnectionStrings["POCOTutorial_DBContext"].ToString();
            model.dept_no = 01;
            model.dept_name = "Marketing";
            model.dept_location = "BTM";
            try
            {
                using(SqlConnection sql = new SqlConnection(connection))
                {
                    sql.Open();
                    string Insertquery = "Insert into Dept_TB values ('" + model.dept_no + "','" + model.dept_name + "','" + model.dept_location + "')";
                    
                    SqlCommand command = new SqlCommand(Insertquery);
                    command.Connection = sql;
                    command.ExecuteNonQuery();
                    sql.Close();
                }
            }
        catch(Exception ex)
    {
        new Exception("Connection Failed..!!");
    }
            return View();
        }

        
	}
}