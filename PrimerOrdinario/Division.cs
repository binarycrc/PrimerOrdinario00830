using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerOrdinario
{
    class Division
    {
        double _dDivisor;
        double _dDividendo;
        double _dResultado;

        public Division()
        {
            _dDivisor = 0;
            _dDividendo = 0;
            _dResultado = 0;
        }

        public Division(double dDivisor, double dDividendo, double dResultado)
        {
            _dDivisor = dDivisor;
            _dDividendo = dDividendo;
            _dResultado = dResultado;
        }

        public double dDivisor { get => _dDivisor; set => _dDivisor = value; }
        public double dDividendo { get => _dDividendo; set => _dDividendo = value; }
        public double dResultado { get => _dResultado; set => _dResultado = value; }

        private double Operacion() 
        {
            double retorno = -1;
            try
            {
                _dResultado = _dDividendo / _dDivisor;
                retorno = _dResultado;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Operacion() Division de {0} by zero.", _dDivisor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operacion() {0}.", ex.Message);
            }
            return retorno;
        }
    }
}
