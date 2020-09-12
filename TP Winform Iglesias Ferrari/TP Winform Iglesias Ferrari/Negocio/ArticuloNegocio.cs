using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos> Listar()
        {
            ///Declarar la shit necesaria para poder conectarse 
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;
            List<Articulos> lista = new List<Articulos>();
            //Configurando conexion
            Conexion.ConnectionString = "data source = DESKTOP-RITUG6V\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = "select id, codigo,  Nombre,  Descripcion, Precio, ImagenUrl  From ARTICULOS as ART";
            ///se ejecuta la conexion
            Comando.Connection = Conexion;
            Conexion.Open();
            ///se manda la query a seleccionar registros
            Lector = Comando.ExecuteReader();

            //Logica una vez conectado, ¿qué tenemos que hacer?
            while (Lector.Read())
            {
                Articulos Aux = new Articulos();
                ///Tenemos que Instanciar un objeto auxiliar al que asignarle los valores
                ///leidos y de ahí sumarlo a la lista  a a a a a 
                /// Vectores dinamicos beiby!
                Aux.Codigo = Lector.GetString(1);
                Aux.Nombre = Lector.GetString(2);
                Aux.Descripcion = Lector.GetString(3);
                Aux.Precio = Lector.GetSqlMoney(4);
                ///OJO A LAS IMAGENES QUE PUEDEN PINCHAR! 
                Aux.Imagen = (string)Lector["ImagenUrl"];
                lista.Add(Aux);

            }
            Conexion.Close();
            return lista;
        }
    }







}

   