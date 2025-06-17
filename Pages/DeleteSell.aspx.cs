using pr_web_car.Models;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace pr_web_car.Pages
{
    public partial class DeleteSell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarVentas();
            }
        }

        private void CargarVentas()
        {
            using (var context = new server_carEntities())
            {
                // Obtencion de la tabla de ventas
                var ventas = context.Sells.ToList();
                GvSells.DataSource = ventas;
                GvSells.DataBind();
            }
        }

        protected void GvSells_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EliminarVenta")
            {
                // Variable para generar mensaje de confirmación
                int idVenta = Convert.ToInt32(e.CommandArgument);

                using (var context = new server_carEntities())
                {
                    var venta = context.Sells.Find(idVenta);
                    // Confirma ID de la venta para su eliminacion.
                    if (venta != null)
                    {
                        context.Sells.Remove(venta);
                        context.SaveChanges();

                        lblMensaje.Text = "✅ Venta eliminada correctamente.";
                    }
                }

                // Volver a cargar tabla
                CargarVentas();
            }
        }
    }
}
