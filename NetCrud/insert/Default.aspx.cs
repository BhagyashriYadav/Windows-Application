using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Net;
using System.IO;
using System.Text;
public partial class _Default : System.Web.UI.Page
{

    private void connection()
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        string Fname = Request.Form["Fname"];
        string Lname = Request.Form["Lname"];

        HttpWebRequest request = WebRequest.Create("http://pravara.aashayweather.com/php/insert.php?id=" + id + "&Fname=" + Fname + "&Lname=" + Lname +"") as HttpWebRequest;
        //Take column name from the database

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        Stream stream = response.GetResponseStream();

        WebHeaderCollection header = response.Headers;
        string responseText = null;

        var encoding = ASCIIEncoding.ASCII;
        using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
        {
            responseText = reader.ReadToEnd();

            if (responseText == "data inserted successfully")
            {

                Response.Write("<script>alert('Resigtration Successfully')</script>");


            }

            else
            {
                Response.Write("<script>alert('Error.')</script>");

            }
        }

    }
}
