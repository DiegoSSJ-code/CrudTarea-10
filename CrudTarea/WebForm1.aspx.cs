using CrudTarea.Clases.archivos;
using CrudTarea.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTarea
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\Win10\Videos\crudDB.csv";
            ClsArchivos ar = new ClsArchivos();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexionSQL cn = new ClsConexionSQL();

            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;
            }

            cn.EjecutaSQLDirecto(sentencia_sql);
        }

            protected void ButtonSubirInformacion_Click(object sender, EventArgs e)
        {
            cargarArchivoExterno();
        }

        protected void Button_CargarInformacionMySQL_Click(object sender, EventArgs e)
        {
            string fuente = @"C:\Users\Win10\Videos\crudDB.csv";
            ClsArchivos ar = new ClsArchivos();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexionMySQL con = new ClsConexionMySQL();

            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;
            }

            con.EjecutaSQLDirecto(sentencia_sql);
        }
    }
}