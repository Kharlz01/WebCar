using pr_web_car.Models;
using System;
using System.Linq;
using System.Web.UI.WebControls;

public partial class Cars : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCars();
        }
    }

    private void LoadCars()
    {
        using (var context = new server_carEntities())
        {
            var cars = context.Cars.ToList();
            GridView1.DataSource = cars;
            GridView1.DataBind();

            var sellers = context.Sellers.ToList();
            GridView2.DataSource = sellers;
            GridView2.DataBind();
        }
    }
}
