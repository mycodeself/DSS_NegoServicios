
using System;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public partial interface IEmpleadoCAD
{
EmpleadoEN ReadOIDDefault (int id);

int New_ (EmpleadoEN empleado);

void Modify (EmpleadoEN empleado);


void Destroy (int id);
}
}
