using pr_web_car.Models;
using System;
using System.Linq;

namespace pr_web_car.Pages
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnConsulta(object sender, EventArgs e)
        {
            // Tomamos la Cedula para la consulta
            string cedula = TxtCC.Text.Trim();

            if (!string.IsNullOrEmpty(cedula))
            {
                using (var context = new server_carEntities())
                {
                    // Llamamos el procedimiento almacenado con el parámetro
                    var resultado = context.sp_VehiculosVendidosPorVendedor(cedula).ToList();

                    if (resultado.Any())
                    {
                        // Mostramos el resultado en el GridView
                        gvVehiculos.DataSource = resultado;
                        gvVehiculos.DataBind();
                        lblMensaje.Visible = false;
                    }
                    else
                    {
                        // Ocultar el panel si no se encontró nada
                        gvVehiculos.DataSource = null;
                        gvVehiculos.DataBind();
                        lblMensaje.Text = "⚠ No se encontró ningúna venta asociada a esa cédula.";
                        lblMensaje.Visible = true;
                    }
                }

            }
            else
            {
                // Advertir al usuario que la cedula no es correcta
                gvVehiculos.DataSource = null;
                gvVehiculos.DataBind();
                lblMensaje.Text = "⚠ Por favor ingresa una cédula válida.";
                lblMensaje.Visible = true;
            }
        }
    }
}
