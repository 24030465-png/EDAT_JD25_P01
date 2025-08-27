using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.NumerosAleatorios
{
    internal class Empleado
    {
        int numero, grupo, sexo;
        String nombre;
        DateTime fecha;
        double sueldo;
        bool seguro;

        public Empleado()
        {

        }
        public Empleado(int num, String nom, int x,DateTime f, int g, double su, bool sg)
        {
            numero = num;
            nombre = nom;
            sexo = x;
            fecha = f;
            grupo = g;
            sueldo = su;
            seguro = sg;
        }

        public int getNumero() { 
            return numero;
        }
        public String getNombre() { 
            return nombre;  
        }
        public int getSexo() { 
            return sexo;    
        }
        public DateTime getFecha() {
            return fecha;
        }
        public int getGrupo() { 
            return grupo;
        }
        public double getSueldo() { 
            return sueldo;
        }
        public bool getSeguro() { 
            return seguro;
        }

        internal string ToString(Func<int> getNumero)
        {
            throw new NotImplementedException();
        }

    }
}
