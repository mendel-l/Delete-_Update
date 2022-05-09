using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Delete__Update
{
    public partial class Delete : System.Web.UI.Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        string SearchDeleteCarne;

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
        void SearchStudentDelete()
        {
            SearchDeleteCarne = TextBoxSerchDelete.Text;
            bool encontrado = false;

            foreach (var uni in universidades)
            {
                Alumno EditStudent = uni.Alumnos.Find(c => c.NoCarne == SearchDeleteCarne);

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
                SearchDeleteCarne = "";
            }
        }
        void DeleteDataStudent()
        {
            SearchDeleteCarne = TextBoxSerchDelete.Text;
            foreach (var uni in universidades)
            {
                Alumno DeleteStudent = uni.Alumnos.Find(c => c.NoCarne == SearchDeleteCarne);

                if (DeleteStudent != null)
                {
                    uni.Alumnos.Remove(DeleteStudent);
                    SaveJsonUnivercity();
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadJsonUnivercity();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SearchStudentDelete();
        }

        protected void ButtonDeleteData_Click(object sender, EventArgs e)
        {
            DeleteDataStudent();
        }
    }
}