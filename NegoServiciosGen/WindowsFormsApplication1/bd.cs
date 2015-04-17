using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NegoServiciosGenNHibernate.Interfaces
{
    public  class bd
    {
        private List<Cliente> clientes;
        public bd()
        {
            clientes=new List<Cliente>();
        }
        public List<Cliente> getClientes(){
            return clientes;
        }
        public void anyadirClientes(Cliente c)
        {
            clientes.Add(c);
        }
        public void eliminarCliente(Cliente c)
        {
            clientes.Remove(c);
        }
        
    }
}
