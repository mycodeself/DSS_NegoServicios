using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NegoServiciosGenNHibernate.Interfaces
{
    class Empleados
    {
        private string[] empleados;
        private string[] contrasenias_empleados;
        public Empleados(){
            empleados = new string[4];
            contrasenias_empleados = new string[4];
            empleados[0]="admin";
            empleados[1]="admin1";
            contrasenias_empleados[0] = "123";
        }
        public string[] getEmpleados(){
            return empleados;
        }
        public string[] getContrasenias()
        {
            return contrasenias_empleados;
        }

    }
}
