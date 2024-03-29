﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(Valor);
        }

        public static DataTable Seleccionar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;

                return Datos.Insertar(obj);
            }

        }


        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria obj = new Categoria();

            if (NombreAnt.Equals(Nombre))
            {
                obj.IdCategoria = Id;
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;

                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    obj.IdCategoria = Id;
                    obj.Nombre = Nombre;
                    obj.Descripcion = Descripcion;

                    return Datos.Actualizar(obj);
                }
            }

            
        }


        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();

            return Datos.Eliminar(Id);
        }


        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();

            return Datos.Activar(Id);
        }


        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();

            return Datos.Desactivar(Id);
        }
    }
}
