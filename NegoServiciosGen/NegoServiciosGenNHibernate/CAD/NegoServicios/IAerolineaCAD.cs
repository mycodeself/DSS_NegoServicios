
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IAerolineaCAD
{
AerolineaEN ReadOIDDefault (int id);

int New_ (AerolineaEN aerolinea);

void Modify (AerolineaEN aerolinea);


void Destroy (int id);


AerolineaEN ReadOID (int id);


System.Collections.Generic.IList<AerolineaEN> ReadAll (int first, int size);


NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN ReadByNombre (string p_nombre);
}
}
