
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
public partial class VueloCAD : BasicCAD, IVueloCAD
{
public VueloCAD() : base ()
{
}

public VueloCAD(ISession sessionAux) : base (sessionAux)
{
}



public VueloEN ReadOIDDefault (int id)
{
        VueloEN vueloEN = null;

        try
        {
                SessionInitializeTransaction ();
                vueloEN = (VueloEN)session.Get (typeof(VueloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vueloEN;
}


public int New_ (VueloEN vuelo)
{
        try
        {
                SessionInitializeTransaction ();
                if (vuelo.Aerolinea != null) {
                        vuelo.Aerolinea = (NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN)session.Load (typeof(NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN), vuelo.Aerolinea.Id);

                        vuelo.Aerolinea.Vuelo.Add (vuelo);
                }

                session.Save (vuelo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vuelo.Id;
}

public void Modify (VueloEN vuelo)
{
        try
        {
                SessionInitializeTransaction ();
                VueloEN vueloEN = (VueloEN)session.Load (typeof(VueloEN), vuelo.Id);

                vueloEN.Origen = vuelo.Origen;


                vueloEN.Destino = vuelo.Destino;


                vueloEN.Fecha_salida = vuelo.Fecha_salida;


                vueloEN.Fecha_llegada = vuelo.Fecha_llegada;


                vueloEN.Hora_salida = vuelo.Hora_salida;


                vueloEN.Hora_llegada = vuelo.Hora_llegada;


                vueloEN.Plazas = vuelo.Plazas;


                vueloEN.Precio_plaza = vuelo.Precio_plaza;

                session.Update (vueloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
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
                VueloEN vueloEN = (VueloEN)session.Load (typeof(VueloEN), id);
                session.Delete (vueloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public VueloEN ReadOID (int id)
{
        VueloEN vueloEN = null;

        try
        {
                SessionInitializeTransaction ();
                vueloEN = (VueloEN)session.Get (typeof(VueloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vueloEN;
}

public System.Collections.Generic.IList<VueloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VueloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VueloEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<VueloEN>();
                else
                        result = session.CreateCriteria (typeof(VueloEN)).List<VueloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> ReadByAerolinea (NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN p_aerolinea)
{
        System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM VueloEN self where FROM VueloEN WHERE aerolinea = :p_aerolinea";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("VueloENreadByAerolineaHQL");
                query.SetParameter ("p_aerolinea", p_aerolinea);

                result = query.List<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in VueloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
