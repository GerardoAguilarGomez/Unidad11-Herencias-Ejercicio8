using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{

    /*  clase hija de persona, con sus atributos particulares */

    public class Estudiante : Persona
    {
        private int nota;


        //en el constrouctor el atributo disponible lo meto directamente a partir de un metodo que comprueba la disponi.
        #region cons 
        public Estudiante()
        {
            this.nombre = "";
            this.sexo = ' ';
            this.edad = 0;
            this.nota = 0;
            this.disponible = saberDisponibilidad();
        }
        public Estudiante(string nombre)
        {
            this.nombre = nombre;
            this.sexo = ' ';
            this.edad = 0;
            this.nota = 0;
            this.disponible = saberDisponibilidad();
        }
        public Estudiante(string nombre,char sexo)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = 0;
            this.nota = 0;
            this.disponible = saberDisponibilidad();
        }
        public Estudiante(string nombre, char sexo,int edad)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad =edad;
            this.nota = 0;
            this.disponible = saberDisponibilidad();
        }

        public Estudiante(string nombre, char sexo, int edad,int nota)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.nota = nota;
            this.disponible = saberDisponibilidad();
        }

        #endregion

        #region getters
        public int Nota { get => nota; set => nota = value; }
        #endregion

        public bool saberDisponibilidad() //compruebo la disp. de los alumnos a partir de un aleatorio de 1 o 2 . tenia q ser 50%
        {
            Random aleatorio = new Random();
            if (aleatorio.Next(1, 3) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string saberAprobado() // devuelvo palabra a partir de la nota
        {
            if (this.nota >= 5)
            {
                return "APROBADO";
            }
            else
            {
                return "SUSPENDIDO";
            }
        }
        public override string ToString()
        {
            return "Alumno:" + this.nombre + ". Sexo: " + sexoCompleto(this.sexo) + ". Edad: " + this.edad + " años. Disponible: " + this.disponible + ". Nota: " + this.nota + ". " + saberAprobado();
        }
    }
}
