using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_1 {
    class Model {
        private double valueFahrenheit;
        private double valueCelsius;

        public Model() {
            ValueCelsius = 0;
        }

        public double ValueFahrenheit {
            get {
                return valueFahrenheit;
            }
            set {
                valueFahrenheit = value;
                valueCelsius = (value - 32) * 5 / 9;
            }
        }

        public double ValueCelsius {
            get {
                return valueCelsius;
            }
            set {
                valueCelsius = value;
                valueFahrenheit = value * 9 / 5 + 32;
            }
        }
    }
}
