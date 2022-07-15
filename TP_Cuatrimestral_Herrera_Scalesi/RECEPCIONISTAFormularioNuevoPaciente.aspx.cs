using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class RECEPCIONISTAFORMULARIONUEVOPACIENTE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 2)
            {
                Response.Redirect("Error.aspx", false);
            }

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    PacienteNegocio pacienteNegocio = new PacienteNegocio();
                    List<Paciente> temporal = pacienteNegocio.listar();
                    //List<Paciente> temporal = (List<Paciente>)Session["listaPacientes"];
                    Paciente seleccionado = temporal.Find(x => x.Id == id);

                    lblId.Text = seleccionado.Id.ToString();
                    txtNombre.Text = seleccionado.Nombre;
                    txtApellido.Text = seleccionado.Apellido;
                    txtDni.Text = seleccionado.Dni.ToString();
                    txtCuit.Text = seleccionado.Cuit;
                    txtTelefono.Text = seleccionado.Telefono;
                    //fecha nac
                    txtDireccion.Text = seleccionado.Direccion;
                    txtEmail.Text = seleccionado.Email;
                    txtClave.Text = seleccionado.Clave;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            //if Modifica , else Alta
            if (Request.QueryString["id"] != null)
            {
                Rol rol = new Rol();
                rol.Id = 4;

                persona.Rol = rol;
                persona.Id = int.Parse(lblId.Text);
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Dni = short.Parse(txtDni.Text);
                persona.Cuit = txtCuit.Text;
                persona.Telefono = txtTelefono.Text;
                //persona.FechaNac = DateTime.Parse(txtFechaNacimiento.Text);
                //persona.FechaNac = DateTime.Now.Date.ToString("yyyy-mm-dd");

                persona.Direccion = txtDireccion.Text;
                persona.Email = txtEmail.Text;
                persona.Clave = txtClave.Text;

                PersonaNegocio personaNegocio = new PersonaNegocio();
                if (personaNegocio.modificar(persona))
                {

                    





                    /*
                    
                    lblGuardadoExitoso.Text += "Guardado exitoso";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDni.Text = "";
                    txtCuit.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";
                    txtEmail.Text = "";
                    txtClave.Text = "";

                    */
                }

            }
            else
            {

                //Persona persona = new Persona();

                //SIEMPRE ES PACIENTE (id_rol = 4)

                Rol rol = new Rol();
                rol.Id = 4;

                persona.Rol = rol;
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Dni = short.Parse(txtDni.Text);
                persona.Cuit = txtCuit.Text;
                persona.Telefono = txtTelefono.Text;

                //persona.FechaNac = DateTime.Parse(txtFechaNacimiento.Text);

                //persona.FechaNac = DateTime.Now.Date.ToString("yyyy-mm-dd");


                persona.Direccion = txtDireccion.Text;
                persona.Email = txtEmail.Text;
                persona.Clave = txtClave.Text;
                persona.Estado = true;

                //Puedo llamar al metodo agregar de PersonaNegocio

                PersonaNegocio personaNegocio = new PersonaNegocio();
                if (personaNegocio.agregar(persona))
                {
                    
                    lblGuardadoExitoso.Text += "Guardado exitoso";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDni.Text = "";
                    txtCuit.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";
                    txtEmail.Text = "";
                    txtClave.Text = "";
                    
                    
                }

            }

            Response.Redirect("GuardadoExitoso.aspx",false);
            
        }

        protected void btnFormularioPrincipal_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("RecepcionistaFormularioPrincipal.aspx", false);
            
        }
    }
}