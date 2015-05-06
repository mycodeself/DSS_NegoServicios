
using System;
using System.Text;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.Exceptions;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial class EmpleadoCAD : BasicCAD, IEmpleadoCAD
{
public EmpleadoCAD() : base ()
{
}

public EmpleadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EmpleadoEN ReadOIDDefault (int id)
{
        EmpleadoEN empleadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                empleadoEN = (EmpleadoEN)session.Get (typeof(EmpleadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleadoEN;
}


public int New_ (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (empleado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleado.Id;
}

public void Modify (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), empleado.Id);

                empleadoEN.Usuario = empleado.Usuario;


                empleadoEN.Password = empleado.Password;


                empleadoEN.Email = empleado.Email;


                empleadoEN.Nombre = empleado.Nombre;

                session.Update (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), id);
                session.Delete (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
