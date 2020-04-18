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
    /// Clase Matriz
    /// </summary>
    class Matriz
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        int _intFilas;
        int _intColumnas;
        int[,] _matrix;
        /// <summary>
        /// Constructor de la clase con los parametros
        /// </summary>
        /// <param name="intFilas"></param>
        /// <param name="intColumnas"></param>
        public Matriz(int intFilas, int intColumnas)
        {
            //asignamos los parametros a los atributos de la clase
            _intFilas = intFilas;
            _intColumnas = intColumnas;
            //asignamos la matriz con las dimensiones solicitadas
            int[,] matrix = new int[_intFilas,_intColumnas];
            //recorremos la matriz segun los atributos
            for (int i = 0; i < _intFilas; i++)
            { 
                for (int j = 0; j < _intColumnas; j++)
                {
                    //si es una diagonal asignamos 1 sino asignamos 0
                    if (i == j) { matrix[i, j] = 1; }
                    else { matrix[i, j] = 0; }
                }
            }
            //asignamos la matriz al atributo de matrix de la clase
            _matrix = matrix;
        }
        /// <summary>
        /// Metodo get/set del atributo _intFilas
        /// </summary>
        public int IntFilas { get => _intFilas; set => _intFilas = value; }
        /// <summary>
        /// Metodo get/set del atributo _intColumnas
        /// </summary>
        public int IntColumnas { get => _intColumnas; set => _intColumnas = value; }
        /// <summary>
        /// Metodo para retornar el valor especifico en la matriz segun
        /// la posicion por parametros
        /// </summary>
        /// <param name="intFilas"></param>
        /// <param name="intColumnas"></param>
        /// <returns>Retorna el valor int de la posicion por parametros</returns>
        public int Matrix(int intFilas, int intColumnas) { return _matrix[intFilas, intColumnas]; }
    }
}
