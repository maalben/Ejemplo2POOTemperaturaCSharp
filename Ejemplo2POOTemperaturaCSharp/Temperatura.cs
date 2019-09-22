using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2POOTemperaturaCSharp
{
    public class Temperatura
    {
        private double grados;

        public void setGrados(double valor) {
            this.grados = valor;
        }

        public double getGrados() {
            return this.grados;
        }

        public double calcularFarenheit() {
            return ((this.getGrados() * 9 / 5) +32);
        }

        public double calcularCentigrados() {
            return ((this.getGrados() - 32) * 5 / 9);
        }
    
    }
}
