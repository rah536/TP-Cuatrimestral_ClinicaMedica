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

    public partial class Agenda : System.Web.UI.Page
    {
        AgendaNegocio agendaNegocio = new AgendaNegocio();

        public List<int> lunes = new List<int>();
        public List<int> martes = new List<int>();
        public List<int> miercoles = new List<int>();
        public List<int> jueves = new List<int>();
        public List<int> viernes = new List<int>();
        public List<int> sabado = new List<int>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 2)
            {
                Response.Redirect("Error.aspx", false);
            }

            //DEBO RECUPERAR ID DESDE EL FORMULARIO ANTERIOR.

            if (!IsPostBack)
            {

                List<Agenda> listaAgenda = new List<Agenda>();

                int idMedico = int.Parse(Request.QueryString["id"].ToString());

                // sumar nombre y apellido del medico a la Agenda
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                List<Medico> listaMedico = medicoNegocio.listar();

                foreach (var item in listaMedico)
                {
                    if (idMedico == item.Id)
                    {
                        lblMedicoNombreApellido.Text += item.Nombre + " " + item.Apellido;
                    }
                }
                //

                agendaNegocio.cargaListaHorario(agendaNegocio.listar(idMedico), lunes, martes, miercoles, jueves, viernes, sabado);

                //ELIMINO DATOS REPETIDOS
                lunes = lunes.Distinct().ToList();
                martes = martes.Distinct().ToList();
                miercoles = miercoles.Distinct().ToList();
                jueves = jueves.Distinct().ToList();
                viernes = viernes.Distinct().ToList();
                sabado = sabado.Distinct().ToList();

                //CARGO LA TABLA (AGENDA)
                foreach (var item in lunes)
                {
                    if (item == 10) lbl10Lunes.Text = "OCUPADO";
                    if (item == 11) lbl11Lunes.Text = "OCUPADO";
                    if (item == 12) lbl12Lunes.Text = "OCUPADO";
                    if (item == 13) lbl13Lunes.Text = "OCUPADO";
                    if (item == 14) lbl14Lunes.Text = "OCUPADO";
                    if (item == 15) lbl15Lunes.Text = "OCUPADO";

                }

                foreach (var item in martes)
                {
                    if (item == 10) lbl10Martes.Text = "OCUPADO";
                    if (item == 11) lbl11Martes.Text = "OCUPADO";
                    if (item == 12) lbl12Martes.Text = "OCUPADO";
                    if (item == 13) lbl13Martes.Text = "OCUPADO";
                    if (item == 14) lbl14Martes.Text = "OCUPADO";
                    if (item == 15) lbl15Martes.Text = "OCUPADO";

                }

                foreach (var item in miercoles)
                {
                    if (item == 10) lbl10Miercoles.Text = "OCUPADO";
                    if (item == 11) lbl11Miercoles.Text = "OCUPADO";
                    if (item == 12) lbl12Miercoles.Text = "OCUPADO";
                    if (item == 13) lbl13Miercoles.Text = "OCUPADO";
                    if (item == 14) lbl14Miercoles.Text = "OCUPADO";
                    if (item == 15) lbl15Miercoles.Text = "OCUPADO";

                }

                foreach (var item in jueves)
                {
                    if (item == 10) lbl10Jueves.Text = "OCUPADO";
                    if (item == 11) lbl11Jueves.Text = "OCUPADO";
                    if (item == 12) lbl12Jueves.Text = "OCUPADO";
                    if (item == 13) lbl13Jueves.Text = "OCUPADO";
                    if (item == 14) lbl14Jueves.Text = "OCUPADO";
                    if (item == 15) lbl15Jueves.Text = "OCUPADO";

                }

                foreach (var item in viernes)
                {
                    if (item == 10) lbl10Viernes.Text = "OCUPADO";
                    if (item == 11) lbl11Viernes.Text = "OCUPADO";
                    if (item == 12) lbl12Viernes.Text = "OCUPADO";
                    if (item == 13) lbl13Viernes.Text = "OCUPADO";
                    if (item == 14) lbl14Viernes.Text = "OCUPADO";
                    if (item == 15) lbl15Viernes.Text = "OCUPADO";

                }

                foreach (var item in sabado)
                {
                    if (item == 10) lbl10Sabado.Text = "OCUPADO";
                    if (item == 11) lbl11Sabado.Text = "OCUPADO";
                    if (item == 12) lbl12Sabado.Text = "OCUPADO";
                    if (item == 13) lbl13Sabado.Text = "OCUPADO";
                    if (item == 14) lbl14Sabado.Text = "OCUPADO";
                    if (item == 15) lbl15Sabado.Text = "OCUPADO";

                }

                //CARGO EL ddl DE DIAS DISPONIBLES

                ddlDiaInicio.Items.Add("Dias disponibles");

                if (lunes.Count < 6) ddlDiaInicio.Items.Add("Lunes");
                if (martes.Count < 6) ddlDiaInicio.Items.Add("Martes");
                if (miercoles.Count < 6) ddlDiaInicio.Items.Add("Miercoles");
                if (jueves.Count < 6) ddlDiaInicio.Items.Add("Jueves");
                if (viernes.Count < 6) ddlDiaInicio.Items.Add("Viernes");
                if (sabado.Count < 6) ddlDiaInicio.Items.Add("Sabado");

                //CARGO LAS ESPECIALIDADES DE ESE MEDICO
                EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();

                //DEBO LISTAR ESPECIALIDADES DEL MEDICO POR ID
                List<string> lista = new List<string>();

                lista = especialidadNegocio.listarPorId(idMedico);

                foreach (var item in lista)
                {
                    ddlEspecialidades.Items.Add(item);
                }
            }
        }


        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioPrincipal.aspx", false);

        }


        protected void ddlHoraInicio_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        
        protected void ddlDiaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlHoraInicio.Items.Clear();
            
            string dia = ddlDiaInicio.SelectedItem.ToString();
            int idMedico = int.Parse(Request.QueryString["id"].ToString());
            
            agendaNegocio.cargaListaHorario(agendaNegocio.listar(idMedico), lunes, martes, miercoles, jueves, viernes, sabado);

            //ELIMINO DATOS REPETIDOS
            lunes = lunes.Distinct().ToList();
            martes = martes.Distinct().ToList();
            miercoles = miercoles.Distinct().ToList();
            jueves = jueves.Distinct().ToList();
            viernes = viernes.Distinct().ToList();
            sabado = sabado.Distinct().ToList();

            //CARGO EL ddl HORARIOS

            if (dia == "Lunes")
            {
                if (!lunes.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!lunes.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!lunes.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!lunes.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!lunes.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!lunes.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!lunes.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!lunes.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!lunes.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!lunes.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!lunes.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!lunes.Contains(15)) ddlHoraFin.Items.Add("15");
            }

            if (dia == "Martes")
            {
                if (!martes.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!martes.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!martes.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!martes.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!martes.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!martes.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!martes.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!martes.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!martes.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!martes.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!martes.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!martes.Contains(15)) ddlHoraFin.Items.Add("15");

            }

            if (dia == "Miercoles")
            {
                if (!miercoles.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!miercoles.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!miercoles.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!miercoles.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!miercoles.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!miercoles.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!miercoles.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!miercoles.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!miercoles.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!miercoles.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!miercoles.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!miercoles.Contains(15)) ddlHoraFin.Items.Add("15");
            }

            if (dia == "Jueves")
            {
                if (!jueves.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!jueves.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!jueves.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!jueves.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!jueves.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!jueves.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!jueves.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!jueves.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!jueves.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!jueves.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!jueves.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!jueves.Contains(15)) ddlHoraFin.Items.Add("15");
            }

            if (dia == "Viernes")
            {
                if (!viernes.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!viernes.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!viernes.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!viernes.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!viernes.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!viernes.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!viernes.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!viernes.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!viernes.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!viernes.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!viernes.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!viernes.Contains(15)) ddlHoraFin.Items.Add("15");
            }

            if (dia == "Sabado")
            {
                if (!sabado.Contains(10)) ddlHoraInicio.Items.Add("10");
                if (!sabado.Contains(11)) ddlHoraInicio.Items.Add("11");
                if (!sabado.Contains(12)) ddlHoraInicio.Items.Add("12");
                if (!sabado.Contains(13)) ddlHoraInicio.Items.Add("13");
                if (!sabado.Contains(14)) ddlHoraInicio.Items.Add("14");
                if (!sabado.Contains(15)) ddlHoraInicio.Items.Add("15");
                if (!sabado.Contains(10)) ddlHoraFin.Items.Add("10");
                if (!sabado.Contains(11)) ddlHoraFin.Items.Add("11");
                if (!sabado.Contains(12)) ddlHoraFin.Items.Add("12");
                if (!sabado.Contains(13)) ddlHoraFin.Items.Add("13");
                if (!sabado.Contains(14)) ddlHoraFin.Items.Add("14");
                if (!sabado.Contains(15)) ddlHoraFin.Items.Add("15");
            }
        }

    }

}