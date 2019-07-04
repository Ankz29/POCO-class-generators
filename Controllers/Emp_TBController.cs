using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace POCO.Controllers
{
    public partial class Emp_TBController : Controller
    {
        //
        // GET: /Emp_TB/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1(Emp_TB model)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["POCOTutorial_DBContext"].ToString();
            model.emp_id = 01;
            model.emp_name = "Ankita";
            model.mgr_emp_id = 01;
            model.dept_no = 01;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string Insertquery = "Insert into Emp_TB values ('"+model.emp_id+"','"+model.emp_name+"','"+model.mgr_emp_id+"','" + model.dept_no + "')";

                    SqlCommand command = new SqlCommand(Insertquery);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
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