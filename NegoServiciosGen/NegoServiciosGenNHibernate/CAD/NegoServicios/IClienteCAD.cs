
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (int id);

int New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (int id);
}
}
