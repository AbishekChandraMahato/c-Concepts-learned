using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indexerss
{
    public class Employee
    {
        public int EmployeeId { set; get; }
        public string name { set; get; }
        public string gender { set; get; }
    }
    public class Company
    {

        private List<Employee> listOfEmployee;
        public Company()
        {
            listOfEmployee = new List<Employee>();
            listOfEmployee.Add(new Employee() { EmployeeId = 101, name = "Abishek", gender = "male" });
            listOfEmployee.Add(new Employee() { EmployeeId = 102, name = "Bikash", gender = "male" });
            listOfEmployee.Add(new Employee() { EmployeeId = 103, name = "Sapana", gender = "female" });
        }
        
        //implementing an indexer
        //this indexer will return name of Employee object from list
        public string this[int employeeId]
        {
            get
            {
                return (listOfEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId)).name;
            }
            set
            {
                (listOfEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId)).name = value;
            }
        }

        //overloading indexers:
        public string this[string gender]
        {
            get
            {
                return listOfEmployee.Count(emp => emp.gender == gender).ToString();
            }
            set
            {
                foreach(Employee em in listOfEmployee)
                {
                    if (em.gender == gender)
                    {
                        em.gender = value;
                    }
                }
            }
        }

    }

}

webform file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexerss
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["session1"] = "session1 data";//using indexers to store data
            Session["session2"] = "session2 data";

            Response.Write("session 1 data:"+Session[0].ToString()+"</br>");//using indexers to retrieve data
            Response.Write("session 1 data:" + Session["Session2"]+ "</br>");



            //using indexer:
            Company company = new Company();
            Response.Write("Name of employee with Id=2: "+company[0]);
            Response.Write("Name of employee with Id=0: " + company[1]);
            Response.Write("Name of employee with Id=1: " + company[2]);

            //changing data

            company[0] = "Abishek Mahato";//change in name

            Response.Write("Total males= "+company["male"]);

               

            

        }
    }
}

