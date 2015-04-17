using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NegoServiciosGenNHibernate.Interfaces
{
    public class Cliente
    {
        private string nombre;
        private string password;
        private string email;
        private string dni;

        public Cliente()
        {

        }
        public Cliente(string nombre,string password,string email,string dni){
            this.nombre = nombre;
            this.password = password;
            this.email = email;
            this.dni = dni;
        }
        public String getNombre(){
            return nombre; 
        }
        public String getPassword()
        {
            return password;
        }
        public String getEmail()
        {
            return email;
        }
        public String getDni()
        {
            return dni;
        }
        public void setNombre(string nombre){
            this.nombre=nombre;
        }
        public void setPassword(string password)
        {
            this.password = password;

        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setDni(string dni)
        {
            this.dni = dni;
        }
        
    }
}
