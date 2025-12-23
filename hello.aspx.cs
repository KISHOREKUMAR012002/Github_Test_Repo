// create a simple ASP.NET Web Forms page that displays "Hello, World!" when accessed.using System;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Hello, World!");
    }
}