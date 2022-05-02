using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Delete__Update
{
    public partial class Update : System.Web.UI.Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        string SearchCarne;
        private void SaveJsonUnivercity()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonUnivercity()
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }
        void SearchStudent()
        {
            SearchCarne = TextBoxSearch.Text;
            bool encontrado = false;

            foreach (var uni in universidades)
            {
                Alumno EditStudent = uni.Alumnos.Find(c => c.NoCarne == SearchCarne);

                if (EditStudent != null)
                {
                    TextBoxName.Text = EditStudent.FirstName;
                    TextBoxLastName.Text = EditStudent.LastName;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Response.Write("<script>alert('no se encontró el carné')</script>");
                SearchCarne = "";
                TextBoxName.Text = "";
                TextBoxLastName.Text = "";
            }
        }
        void ChangeDataStudent()
        {
            foreach (var uni in universidades)
            {
                int EditStudent = uni.Alumnos.FindIndex(c => c.NoCarne == SearchCarne);

                if (EditStudent != -1)
                {
                    uni.Alumnos[EditStudent].FirstName = TextBoxName.Text;
                    uni.Alumnos[EditStudent].LastName = TextBoxLastName.Text;

                    SaveJsonUnivercity();
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadJsonUnivercity();
        }
        protected void ButtonSerchStudent_Click(object sender, EventArgs e)
        {
            SearchCarne = TextBoxSearch.Text;
            bool encontrado = false;

            foreach (var uni in universidades)
            {
                Alumno EditStudent = uni.Alumnos.Find(c => c.NoCarne == SearchCarne);

                if (EditStudent != null)
                {
                    TextBoxName.Text = EditStudent.FirstName;
                    TextBoxLastName.Text = EditStudent.LastName;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Response.Write("<script>alert('no se encontró el carné')</script>");
                SearchCarne = "";
                TextBoxName.Text = "";
                TextBoxLastName.Text = "";
            }
        }
        protected void ButtonChangeData_Click(object sender, EventArgs e)
        {
            foreach (var uni in universidades)
            {
                int EditStudent = uni.Alumnos.FindIndex(c => c.NoCarne == SearchCarne);

                if (EditStudent != -1)
                {
                    uni.Alumnos[EditStudent].FirstName = TextBoxName.Text;
                    uni.Alumnos[EditStudent].LastName = TextBoxLastName.Text;

                    SaveJsonUnivercity();
                }
            }
        }
    }
}