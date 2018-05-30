using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AdventureWorks.Data;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;

namespace SubSonic3.WebDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            NorthwindDB db = new NorthwindDB();
            var item = from e1 in db.Employees
                       select e1;

            var sp = db.uspUpdateEmployeePersonalInfo();
            //sp.
            var sp1 = db.uspGetEmployeesByHireDate();

            sp1.Command.AddParameter("@HireDate", DateTime.Now.AddYears(-50),DbType.DateTime);
            sp1.Execute();
            //DataSet ds = sp1.ExecuteDataSet();
            var result = sp1.ExecuteTypedList<Employee>();
           // sp1.ParameterName = "@HireDate";
            //sp1.ExecuteDataSet(DateTime.Now.AddYears(-50));


            foreach (var em in item)
            {
                string str = em.BirthDate.ToString();
            }
                
        }
    }
}
