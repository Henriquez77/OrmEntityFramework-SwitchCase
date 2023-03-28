using System;
using System.Linq;
using OrmEntityFramework.Models;
using OrmEntityFramework.DAO;
namespace OrmEntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region CodigoMio
            //Scaffold-DbContext "Server=DESKTOP-VI57TV8\HWJHONATAN;Database=OrmEntityFramework;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
            //Console.WriteLine("Hello World!");
            //using (OrmEntityFrameworkContext db = new OrmEntityFrameworkContext()) {

            //var ListUsuarios = db.Usuarios.ToList();
            //foreach (var mostrar in ListUsuarios)
            //{
            //    Console.WriteLine(mostrar.Nombre);
            //}
            //Usuario usuario = new Usuario();
            //usuario.Nombre = "Jhonatan";
            //usuario.Apellido = "Henriquez";
            //usuario.Edad = 20;
            //db.Usuarios.Add(usuario);
            //db.SaveChanges();

            //var buscar = db.Usuarios.FirstOrDefault(x => x.Id == 1);
            //Console.WriteLine(buscar.Nombre);
            //Console.WriteLine(buscar.Apellido);
            //Console.WriteLine(buscar.Edad);

            //var where = db.Usuarios.Where(x => x.Id == 1);
            //Console.WriteLine(where);

            //buscar.Nombre = "Henriquez";
            //db.SaveChanges();
            //db.Usuarios.Update(buscar);

            //    db.Usuarios.Remove(buscar);
            //    db.SaveChanges();

            //}

            //CrudUsuarios crudUsuarios = new CrudUsuarios();
            //Usuario usuario = new Usuario();
            //usuario.Nombre = "Jhonatan";
            //usuario.Apellido = "Hola";
            //usuario.Edad = 20;

            ////crudUsuarios.AgregarUsuario(usuario);

            //usuario.Id = 1002;
            //crudUsuarios.ActualizarUsuario(usuario);
            #endregion 
            CrudUsuarios CrudUsuarios = new CrudUsuarios();
            Usuario Usuario = new Usuario();


            Console.WriteLine("Menu");
            Console.WriteLine("Pulse 1 para realizar insertar usuarios");
            Console.WriteLine("Pulse 2 para realizar una actualizacion de usuarios");
            var Menu = Convert.ToInt32(Console.ReadLine());


            switch (Menu)
            {

                case 1:
                    int bucle = 1;
                    while (bucle == 1)
                    {
                        Console.WriteLine("Ingresa tu nombre");
                        Usuario.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa tu apellido");
                        Usuario.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingresa tu edad");
                        Usuario.Edad = Convert.ToInt32(Console.ReadLine());
                        CrudUsuarios.AgregarUsuario(Usuario);
                        Console.WriteLine("El usuario se ingreso correctamente");
                        Console.WriteLine("Pulsa 1 para continuar insertando usuarios");
                        Console.WriteLine("Pulsa 0 para salir");
                        bucle = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2:
                    Console.WriteLine("Actualizar datos");
                    Console.WriteLine("Ingresa el ID del usuario a actualizar");
                    var UsuarioIndividual = CrudUsuarios.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
                    if (UsuarioIndividual == null)
                    {
                        Console.WriteLine("El usuario no existe");
                    }
                    else
                    {
                        Console.WriteLine($"Nombre {UsuarioIndividual.Nombre} , Apellido {UsuarioIndividual.Apellido} , Edad {UsuarioIndividual.Edad}");
                        Console.WriteLine("Para actualizar nombre coloca el # 1");
                        Console.WriteLine("Para actualizar el apellido coloca el # 2");
                        Console.WriteLine("Para actualizar la edad coloca el # 3");
                        var Lector = Convert.ToInt32(Console.ReadLine());
                        switch (Lector)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nombre");
                                UsuarioIndividual.Nombre = Console.ReadLine();
                                CrudUsuarios.ActualizarUsuario(UsuarioIndividual, Lector);
                                Console.WriteLine("Actualizado correctamente");
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el apellido");
                                UsuarioIndividual.Apellido = Console.ReadLine();
                                CrudUsuarios.ActualizarUsuario(UsuarioIndividual, Lector);
                                Console.WriteLine("Actualizado correctamente");
                                break;
                            case 3:
                                Console.WriteLine("Ingrese la edad");
                                UsuarioIndividual.Edad = int.Parse(Console.ReadLine());
                                CrudUsuarios.ActualizarUsuario(UsuarioIndividual, Lector);
                                Console.WriteLine("Actualizado correctamente");
                                break;
                            default:
                                Console.WriteLine("Opcion ivalida!");
                                break;
                        }
                        //if (Lector == 1)
                        //{
                        //    Console.WriteLine("Ingrese el nombre");
                        //    UsuarioIndividual.Nombre = Console.ReadLine();
                        //}
                        //else if (Lector == 2)
                        //{
                        //    Console.WriteLine("Ingrese el apellido");
                        //    UsuarioIndividual.Apellido = Console.ReadLine();
                        //}
                        //else if (Lector == 3)
                        //{
                        //    Console.WriteLine("Ingrese la edad");
                        //    UsuarioIndividual.Edad = int.Parse(Console.ReadLine());
                        //}
                        //else {
                        //    Console.WriteLine("Opcion ivalida!");
                        //    break;
                        //}
                        //CrudUsuarios.ActualizarUsuario(UsuarioIndividual, Lector);
                        //Console.WriteLine("Actualizado correctamente");
                    }
                    break;
            }
            //Usuario.Id = 3;



            //CrudUsuarios.AgregarUsuario(Usuario);
            //CrudUsuarios.ActualizarUsuario(Usuario);

            //OrmEntityFrameworkContext db = new OrmEntityFrameworkContext();

            //var buscar = db.Usuarios.FirstOrDefault(x => x.Id == 1);

            //db.Usuarios.Remove(buscar);
            //db.SaveChanges();
            #region Actualizar
            //buscar.Nombre = "Efrain";
            //buscar.Apellido = "Villacorta";

            //db.Usuarios.Update(buscar);
            //db.SaveChanges();
            #endregion
            //Console.WriteLine(buscar);
            #region Listar
            //var ListUsuarios = db.Usuarios.ToList();

            //        foreach (var usu in ListUsuarios) {
            //            Console.WriteLine(usu.Nombre);
            //        }

            #endregion
            #region Insertar
            //Usuario usuario = new Usuario();
            //usuario.Nombre = "Mario";
            //usuario.Apellido = "Alas";
            //usuario.Edad = 18;

            //db.Usuarios.Add(usuario);
            //db.SaveChanges();
            #endregion

        }
    }
}
