using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    /* Clase padre donde creo los atributos principales*/
    public class Persona
    {
        protected string nombre;
        protected char sexo;
        protected int edad;
        protected bool disponible;

        //

        #region getters
        public string Nombre { get => nombre; set => nombre = value; }
        public char Sexo { get => sexo; set => sexo=value; }
        public int Edad { get => edad; set => edad=value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        #endregion

        public string sexoCompleto(char inicial_sexo) // metodo para q a partir de la inicial del sexo devuelva el sexo completo
        {

            switch (inicial_sexo)
            {
                case 'H':
                    return "Hombre";
                case 'M':
                    return  "Mujer";
                default:
                    return "";
            }
        }
    }
}
