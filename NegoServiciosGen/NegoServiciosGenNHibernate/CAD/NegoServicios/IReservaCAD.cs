
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IReservaCAD
{
ReservaEN ReadOIDDefault (int id);

int New_ (ReservaEN reserva);

void Modify (ReservaEN reserva);


void Destroy (int id);


ReservaEN ReadOID (int id);


System.Collections.Generic.IList<ReservaEN> ReadAll (int first, int size);


System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByCliente (NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN p_usuario);


System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByEstado (NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum p_estado);


System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByVuelo (NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN p_vuelo);
}
}
