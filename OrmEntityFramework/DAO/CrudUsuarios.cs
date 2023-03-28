using System;
using System.Collections.Generic;
using System.Text;
using OrmEntityFramework.Models;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace OrmEntityFramework.DAO
{
    public class CrudUsuarios
    {
        public void AgregarUsuario(Usuario ParamUsuario)
        {
            using (OrmEntityFrameworkContext db = new OrmEntityFrameworkContext())
            {
                //Usuario usuario = new Usuario();
                //usuario.Nombre = ParamUsuario.Nombre;
                //usuario.Apellido = ParamUsuario.Apellido;
                //usuario.Edad = ParamUsuario.Edad;
                db.Add(ParamUsuario);
                db.SaveChanges();
            }

        }
        public void ActualizarUsuario(Usuario ParamUsuario, int Lector)
        {
            using (OrmEntityFrameworkContext db = new OrmEntityFrameworkContext())
            {
                try
                {
                    var buscar = UsuarioIndividual(ParamUsuario.Id);
                    //Usuario usuario = new Usuario();
                    //usuario.Nombre = ParamUsuario.Nombre;
                    //usuario.Apellido = ParamUsuario.Apellido;
                    //usuario.Edad = ParamUsuario.Edad;
                    if(buscar == null)
                    {
                        Console.WriteLine("El id no existe");
                    }
                    else
                    {
                        switch (Lector)
                        {
                            case 1:
                                buscar.Nombre = ParamUsuario.Nombre;
                                break;

                            case 2:
                                //Bug
                                buscar.Apellido = ParamUsuario.Apellido;
                                break;

                            case 3:
                                buscar.Edad = ParamUsuario.Edad;
                                break;
                        }
                        //if(Lector == 1)
                        //{
                        //    buscar.Nombre = ParamUsuario.Nombre;
                        //}
                        //else if(Lector == 2)
                        //{
                        //    //Bug
                        //    buscar.Apellido = ParamUsuario.Apellido;
                        //}else if(Lector == 3)
                        //{
                        //    buscar.Edad = ParamUsuario.Edad;
                        //}
                    }
                    db.Update(ParamUsuario);
                
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    Console.WriteLine($"Error, ID {ParamUsuario.Id} no esta registrado");
                }
                

            }
        }
        public Usuario UsuarioIndividual(int ParamUsuario)
        {
            using (OrmEntityFrameworkContext db = new OrmEntityFrameworkContext())
            {

                var buscar = db.Usuarios.FirstOrDefault(x => x.Id == ParamUsuario);
                return buscar;
            }
        }
    }
}
