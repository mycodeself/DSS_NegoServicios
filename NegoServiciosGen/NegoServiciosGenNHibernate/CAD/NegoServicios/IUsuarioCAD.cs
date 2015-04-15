
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int id);

int New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (int id);


UsuarioEN ReadOID (int id);


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByUsuario (string p_user);
}
}
