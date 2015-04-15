
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
public partial class AerolineaCAD : BasicCAD, IAerolineaCAD
{
public AerolineaCAD() : base ()
{
}

public AerolineaCAD(ISession sessionAux) : base (sessionAux)
{
}



public AerolineaEN ReadOIDDefault (int id)
{
        AerolineaEN aerolineaEN = null;

        try
        {
                SessionInitializeTransaction ();
                aerolineaEN = (AerolineaEN)session.Get (typeof(AerolineaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return aerolineaEN;
}


public int New_ (AerolineaEN aerolinea)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (aerolinea);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return aerolinea.Id;
}

public void Modify (AerolineaEN aerolinea)
{
        try
        {
                SessionInitializeTransaction ();
                AerolineaEN aerolineaEN = (AerolineaEN)session.Load (typeof(AerolineaEN), aerolinea.Id);

                aerolineaEN.Nombre = aerolinea.Nombre;

                session.Update (aerolineaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
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
                AerolineaEN aerolineaEN = (AerolineaEN)session.Load (typeof(AerolineaEN), id);
                session.Delete (aerolineaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public AerolineaEN ReadOID (int id)
{
        AerolineaEN aerolineaEN = null;

        try
        {
                SessionInitializeTransaction ();
                aerolineaEN = (AerolineaEN)session.Get (typeof(AerolineaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return aerolineaEN;
}

public System.Collections.Generic.IList<AerolineaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AerolineaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AerolineaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AerolineaEN>();
                else
                        result = session.CreateCriteria (typeof(AerolineaEN)).List<AerolineaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN> ReadByNombre (string p_nombre)
{
        System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AerolineaEN self where FROM AerolineaEN WHERE nombre = :p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AerolineaENreadByNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in AerolineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
