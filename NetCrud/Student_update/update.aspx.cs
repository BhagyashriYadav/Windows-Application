
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

public partial class update : System.Web.UI.Page
{

    private void connection()
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        //string ID = Request.Form["txtid"];
        string First_Name = Request.Form["txtfname"];
       // string Middle_Name = Request.Form["txtmname"];
       // string Last_Name = Request.Form["Textlame"];
       // string Std = Request.Form["Textstd"];
        string Email = Request.Form["Textemail"];
        string PRN = Request.Form["Textprn"];
        //string Subject = Request.Form["Textsub"];
       // string Marks = Request.Form["Textmarks"];
        //string Intrest = Request.Form["Textintrest"];



        HttpWebRequest request = WebRequest.Create("http://hydromet.cwprsaws.co.in/Student_update.php?fname=" + First_Name + "&email=" + Email + "&prn=" + PRN + "") as HttpWebRequest;
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        Stream stream = response.GetResponseStream();
        WebHeaderCollection header = response.Headers;
        string responseText = null;
        var encoding = ASCIIEncoding.ASCII;
        using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
        {
            responseText = reader.ReadToEnd();
        }
        if (responseText == "Update Successfull")
        {
            Response.Write("<script>alert('update successful')</script>");
        }
        else
        {
            Response.Write("<script>alert('update not successful')</script>");
        }



    }



    //  SqlConnection con = new SqlConnection(constr);
    //  con.Open();
    //     SqlCommand cmd = new SqlCommand("insert into shri(Name,Address,Email) values ('" + txtname.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "'", con);
    //  cmd.ExecuteNonQuery();
    //  con.Close();


}
