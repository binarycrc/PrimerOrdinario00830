/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerOrdinario
{
    /// <summary>
    /// Clase division
    /// </summary>
    class Division
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        double _dDivisor;
        double _dDividendo;
        double _dResultado;

        /// <summary>
        /// Constructor general de la clase
        /// </summary>
        public Division()
        {
            _dDivisor = 0;
            _dDividendo = 0;
        }
        /// <summary>
        /// Constructor de la clase con parametros
        /// </summary>
        /// <param name="dDivisor"></param>
        /// <param name="dDividendo"></param>
        public Division(double dDivisor, double dDividendo)
        {
            //asignamos los parametros a los atributos
            _dDivisor = dDivisor; 
            _dDividendo = dDividendo;
        }
        /// <summary>
        /// Metodo get/set del atributo _dDivisor
        /// </summary>
        public double dDivisor { get => _dDivisor; set => _dDivisor = value; }
        /// <summary>
        /// Metodo get/set del atributo _dDividendo
        /// </summary>
        public double dDividendo { get => _dDividendo; set => _dDividendo = value; }
        /// <summary>
        /// Metodo get del atributo dResultado
        /// despues de asignarle el valor por el metodo Operacion
        /// </summary>
        public double dResultado { get => Operacion();}
        /// <summary>
        /// Metodo para el calculo de division 
        /// </summary>
        /// <returns>Retorna el resultado de la division</returns>
        private double Operacion() 
        {
            double retorno = -1;
            try
            {
                _dResultado = _dDividendo / _dDivisor;
                retorno = _dResultado;
            }
            catch (DivideByZeroException)
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
