
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IVueloCAD
{
VueloEN ReadOIDDefault (int id);

int New_ (VueloEN vuelo);

void Modify (VueloEN vuelo);


void Destroy (int id);


VueloEN ReadOID (int id);


System.Collections.Generic.IList<VueloEN> ReadAll (int first, int size);


System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> ReadByAerolinea (NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN p_aerolinea);
}
}
