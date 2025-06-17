using pr_web_car.Models;
using System;
using System.Web.UI;
using System.Xml.Linq;

namespace pr_web_car.Pages
{
    public partial class Brand : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txt_name.Text.Trim();
            string pais = txt_country.Text.Trim();
            string fechaFundacionTexto = txt_start.Text.Trim();

            // Condicional para evitar campos vacios
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pais) || string.IsNullOrEmpty(fechaFundacionTexto))
            {
                lblMensaje.Text = "⚠ Por favor completa todos los campos.";
                lblMensaje.CssClass = "alert alert-warning mb-1";
                lblMensaje.Visible = true;
                return;
            }

            // Generamos la memoria para determinar el año.
            int? fechaFundacion = null;
            if (int.TryParse(txt_start.Text.Trim(), out int year))
            {
                // Validacion para verificar que ingresa un año real.
                if (year >= 1800 && year <= DateTime.Now.Year)
                {
                    fechaFundacion = year;
                }
                else
                {
                    // Mensaje de error para evitar años invalidos
                    lblMensaje.Text = "⚠ Ingrese un año válido.";
                    lblMensaje.Visible = true;
                    return;
                }
            }

            try
            {
                // Se verifica informacion para crear en la Base de Datos.
                using (var context = new server_carEntities())
                {
                    Brands nuevaMarca = new Brands
                    {
                        NameBrand = nombre,
                        OriginCountry = pais,
                        StartDate = fechaFundacion,
                        Active = true
                    };

                    context.Brands.Add(nuevaMarca);
                    context.SaveChanges();
                }

                lblMensaje.Text = "✅ Marca creada exitosamente.";
                lblMensaje.CssClass = "alert alert-success mb-1";
                lblMensaje.Visible = true;
                LimpiarFormulario(); // Limpia los campos después de crear
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "❌ Error al crear la marca: " + ex.Message;
                lblMensaje.CssClass = "alert alert-danger mb-1";
                lblMensaje.Visible = true;
            }
        }
        // Boton de limpieza de casillas.
        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            lblMensaje.Visible = false;
        }

        // Funcion con el fin de no repetir lineas de limpieza.
        private void LimpiarFormulario()
        {
            txt_name.Text = "";
            txt_country.Text = "";
            txt_start.Text = "";
        }
    }
}
