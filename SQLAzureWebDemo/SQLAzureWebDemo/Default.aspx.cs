using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using SQLAzureWebDemo.Utils;

namespace SQLAzureWebDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        //SqlConnection objConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlAzureConn"].ConnectionString);
        //objConn.Open(); 
        
       // objConn.Close();

            //CreateTables();

            //InsertData();

            if (!IsPostBack)
            {
               SelectData();
               getAllTables();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            InsertData(txtFName.Text + rand.Next().ToString(), txtLName.Text + rand.Next().ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            CreateTables(txtTableName.Text + rand.Next().ToString());
        }

        public void CreateTables(string tableName)
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
            objConn.Open();

            string sSQL = @"CREATE TABLE {0} 
			( FirstName varchar(50) NOT NULL, LastName varchar(50) NULL, 
			CONSTRAINT PK_TestTable{0} PRIMARY KEY (FirstName) )";

            sSQL = String.Format(sSQL, tableName);

            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.CommandType = System.Data.CommandType.Text;
            objCmd.ExecuteNonQuery();

            objConn.Close();

            getAllTables();

        }


        public void CreateTables()
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
        objConn.Open();

        string sSQL = @"CREATE TABLE myTestTable 
			( FirstName varchar(50) NOT NULL, LastName varchar(50) NULL, 
			CONSTRAINT PK_TestTable PRIMARY KEY (FirstName) )";

       

        SqlCommand objCmd = new SqlCommand(sSQL, objConn);
        objCmd.CommandType = System.Data.CommandType.Text;
        objCmd.ExecuteNonQuery();

        objConn.Close();

        getAllTables();

        }


        public void getAllTables()
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
            objConn.Open();

            string sSQL = "sp_tables";


            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(objCmd);

            DataSet dsSet = new DataSet();

            sqlDA.Fill(dsSet, "myTables");

            DataView dView = dsSet.Tables[0].DefaultView;
            dView.RowFilter = " TABLE_TYPE = 'TABLE' ";
            //var sel = from dr in dsSet.Tables[0].Rows
                     // where Convert.ToString(dr["TABLE_TYPE"]) == "TABLE"
                     // select dr;

            gvTables.DataSource = dView;
            gvTables.DataBind();

           

        }

        public void InsertData()
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
            objConn.Open();
          
            string sSQL = "INSERT INTO myTestTable (FirstName, LastName) VALUES ('Giridhar Kumar', 'Govindu') ";



            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.CommandType = System.Data.CommandType.Text;
            objCmd.ExecuteNonQuery();

            objConn.Close();

            SelectData();

        }

        public void InsertData(string FName,string LName)
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
            objConn.Open();

            string sSQL = "INSERT INTO myTestTable (FirstName, LastName) VALUES ('{0}', '{1}') ";

            sSQL = String.Format(sSQL, FName, LName);
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.CommandType = System.Data.CommandType.Text;
            objCmd.ExecuteNonQuery();

            objConn.Close();

            SelectData();

        }

        public void SelectData()
        {
            SqlConnection objConn = SqlUtil.GetConnection("SqlAzureConn");
            objConn.Open();

            string sSQL = "SELECT * from myTestTable ";

            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter sqlDA = new SqlDataAdapter(objCmd);

            DataSet dsSet = new DataSet();

            sqlDA.Fill(dsSet, "myTestTable");
            //objCmd.ExecuteNonQuery();
            string strFName = string.Empty;
            string strLName = string.Empty;
            foreach (DataRow dr in dsSet.Tables[0].Rows)
            {
                strFName = Convert.ToString(dr["FirstName"]);
                strLName = Convert.ToString(dr["LastName"]);
            }

            GridView1.DataSource = dsSet;
            GridView1.DataBind();

            objConn.Close();

        }



    }
}
