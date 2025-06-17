using pr_web_car.Models;
using System;
using System.Linq;
using System.Web.UI;

namespace pr_web_car
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Seccion de Consulta
        protected void BtnCC_Click(object sender, EventArgs e)
        {
            string cedula = TxtCC.Text.Trim();

            if (!string.IsNullOrEmpty(cedula))
            {
                using (var context = new server_carEntities())
                {
                    // Toma la cedula para la busqueda
                    var seller = context.Sellers.FirstOrDefault(s => s.CC == cedula);

                    if (seller != null)
                    {
                        // Llenar los campos
                        txt_name.Text = seller.NameSeller;
                        txt_lastname.Text = seller.LastName;
                        txt_start.Text = seller.StartDate.ToString("yyyy-MM-dd");
                        txt_wage.Text = seller.BaseWage.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        txt_plus.Text = seller.ComissionRate.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);

                        // Mostrar el panel con el formulario
                        pnlFormulario.Visible = true;
                        // Oculta cualquier mensaje previo
                        lblMensaje.Visible = false;
                    }
                    else
                    {
                        // Ocultar el panel si no se encontró nada
                        pnlFormulario.Visible = false;
                        lblMensaje.Text = "⚠ No se encontró ningún vendedor con esa cédula.";
                        lblMensaje.Visible = true;
                    }
                }
            } else {
                // Advertir al usuario para que ingrese una CC valida.
                pnlFormulario.Visible = false;
                lblMensaje.Text = "⚠ Por favor ingresa una cédula válida.";
                lblMensaje.Visible = true;
            }
        }


        // ACTUALIZAR
        // Gestion con la base de datos para actualizar informacion del usuario.
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string cedula = TxtCC.Text.Trim();

            using (var context = new server_carEntities())
            {
                var seller = context.Sellers.FirstOrDefault(s => s.CC == cedula);

                if (seller != null)
                {
                    seller.NameSeller = txt_name.Text.Trim();
                    seller.LastName = txt_lastname.Text.Trim();
                    seller.StartDate = DateTime.Parse(txt_start.Text);
                    seller.BaseWage = decimal.Parse(txt_wage.Text);
                    seller.ComissionRate = int.Parse(txt_plus.Text);

                    context.SaveChanges();

                    ScriptManager.RegisterStartupScript(this, GetType(), "alerta", "alert('Datos actualizados correctamente.');", true);
                }
            }
        }

        // CANCELAR
        // Boton de limpieza para no sobreescribir con los datos digitados.
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            pnlFormulario.Visible = false;
            TxtCC.Text = "";
            txt_name.Text = "";
            txt_lastname.Text = "";
            txt_start.Text = "";
            txt_wage.Text = "";
            txt_plus.Text = "";
        }
    }
}
