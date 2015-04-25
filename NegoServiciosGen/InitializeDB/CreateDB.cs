
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                NegoServiciosGenNHibernate.EN.NegoServicios.EmpleadoEN empleado = new EmpleadoEN ();
                empleado.Email = "empleado@ns.com";
                empleado.Usuario = "emp";
                empleado.Password = "emp";
                empleado.Nombre = "Empleado";
                EmpleadoCEN empleadoCEN = new EmpleadoCEN ();
                empleadoCEN.New_ (empleado.Usuario, empleado.Password, empleado.Email, empleado.Nombre);

                ClienteCEN clienteCEN = new ClienteCEN ();
                clienteCEN.New_ ("cli", "cli", "cli@ns.com", "12345678X");
                clienteCEN.New_ ("pepe", "pepe", "pepe@gmail.com", "99999999Z");

                AerolineaCEN aerolineaCEN = new AerolineaCEN();
                aerolineaCEN.New_("Iberia");
                aerolineaCEN.New_("Air Europa");
                aerolineaCEN.New_("Air Nostrum");
                aerolineaCEN.New_("Easy Jet");
                aerolineaCEN.New_("Ryanair");
                /*List<NegoServiciosGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<NegoServiciosGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * NegoServiciosGenNHibernate.EN.Mediaplayer.UserEN userEN = new NegoServiciosGenNHibernate.EN.Mediaplayer.UserEN();
                 * NegoServiciosGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new NegoServiciosGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * NegoServiciosGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new NegoServiciosGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * NegoServiciosGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new NegoServiciosGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * NegoServiciosGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new NegoServiciosGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * NegoServiciosGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new NegoServiciosGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * NegoServiciosGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new NegoServiciosGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //NegoServiciosGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new NegoServiciosGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/




                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
