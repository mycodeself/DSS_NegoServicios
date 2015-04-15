
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
public partial class ReservaCAD : BasicCAD, IReservaCAD
{
public ReservaCAD() : base ()
{
}

public ReservaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReservaEN ReadOIDDefault (int id)
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}


public int New_ (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                if (reserva.Cliente != null) {
                        reserva.Cliente = (NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN)session.Load (typeof(NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN), reserva.Cliente.Id);

                        reserva.Cliente.Reserva.Add (reserva);
                }
                if (reserva.Vuelo != null) {
                        reserva.Vuelo = (NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN)session.Load (typeof(NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN), reserva.Vuelo.Id);

                        reserva.Vuelo.Reserva.Add (reserva);
                }

                session.Save (reserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reserva.Id;
}

public void Modify (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaEN reservaEN = (ReservaEN)session.Load (typeof(ReservaEN), reserva.Id);

                reservaEN.Plazas = reserva.Plazas;


                reservaEN.Estado = reserva.Estado;

                session.Update (reservaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
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
                ReservaEN reservaEN = (ReservaEN)session.Load (typeof(ReservaEN), id);
                session.Delete (reservaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ReservaEN ReadOID (int id)
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}

public System.Collections.Generic.IList<ReservaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReservaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                else
                        result = session.CreateCriteria (typeof(ReservaEN)).List<ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByCliente (NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN p_usuario)
{
        System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaEN self where FROM ReservaEN WHERE cliente = :p_cliente";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaENreadByClienteHQL");
                query.SetParameter ("p_usuario", p_usuario);

                result = query.List<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByEstado (NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum p_estado)
{
        System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaEN self where FROM ReservaEN WHERE estado = :p_estado";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaENreadByEstadoHQL");
                query.SetParameter ("p_estado", p_estado);

                result = query.List<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByVuelo (NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN p_vuelo)
{
        System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaEN self where FROM ReservaEN WHERE vuelo = :p_vuelo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaENreadByVueloHQL");
                query.SetParameter ("p_vuelo", p_vuelo);

                result = query.List<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is NegoServiciosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new NegoServiciosGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
