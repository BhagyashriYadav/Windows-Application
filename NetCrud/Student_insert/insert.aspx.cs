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
public partial class insert : System.Web.UI.Page
{

    private void connection()


    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsert_Click(object sender, EventArgs e)
    {
        string ID = Request.Form["txtid"];
        string First_Name = Request.Form["txtfname"];
        string Middle_Name = Request.Form["txtmname"];
        string Last_Name = Request.Form["Textlame"];
        string Std = Request.Form["Textstd"];
        string Email = Request.Form["Textemail"];
        string PRN = Request.Form["Textprn"];
        string Subject = Request.Form["Textsub"];
        string Marks = Request.Form["Textmarks"];
        string Intrest = Request.Form["Textintrest"];
      
       

        HttpWebRequest request = WebRequest.Create("http://hydromet.cwprsaws.co.in/Sinsert.php?id=" + ID + "&fname=" + First_Name + "&mname=" + Middle_Name + "&lame=" + Last_Name + "&std=" + Std + "&email=" + Email + "&prn=" + PRN + "&sub=" + Subject + "&marks=" + Marks+ "&intrest=" + Intrest +"") as HttpWebRequest;
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        Stream stream = response.GetResponseStream();

        WebHeaderCollection header = response.Headers;
        string responseText = null;
        var encoding = ASCIIEncoding.ASCII;
        using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
        {
            responseText = reader.ReadToEnd();
        }
        if (responseText == "Registration Success")
        {
            Response.Write("<script>alert('Registration Success')</script>");
        }
        else
        {
            Response.Write("<script>alert('Insert not successful')</script>");
        }

    }

}
