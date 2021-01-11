using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{

    //clase hija de persona
    public class Profesor:Persona
    {
        private string materia;
        private string[] asig = { "Matemáticas", "Filosofía", "Física" };

        #region cons
        public Profesor()
        {
            this.nombre = "";
            this.sexo = ' ';
            this.edad = 0;
            this.materia = "";
            this.disponible = saberDisponibilidad();
        }
        public Profesor(string nombre)
        {
            this.nombre = nombre;
            this.sexo = ' ';
            this.edad = 0;
            this.materia= "";
            this.disponible = saberDisponibilidad();
        }
        public Profesor(string nombre, char sexo)
        {
            this.nombre = nombre;
            this.sexo = validaSexo();
            this.edad = 0;
            this.materia = "";
            this.disponible = saberDisponibilidad();
        }
        public Profesor(string nombre, char sexo, int edad)
        {
            this.nombre = nombre;
            this.sexo = validaSexo();
            this.edad = edad;
            this.materia = "";
            this.disponible = saberDisponibilidad();
        }

        public Profesor(string nombre, char sexo, int edad, string materia)
        {
            this.nombre = nombre;
            this.sexo = validaSexo();
            this.edad = edad;
            this.materia = validarMateria(materia);
            this.disponible = saberDisponibilidad();
        }
        #endregion

        #region getters
        public string Materia { get => materia; set => materia = value; }
        #endregion

        public string validarMateria(string mat)
        {


            for(int i = 0; i < asig.Length; i++)
            {
                if (asig[i] == mat)
                {
                    return mat;
                }
            }

            return "Matemáticas";
            
        }

        public bool saberDisponibilidad() //compruebo la disp. de los profes a partir de un aleatorio de 1 a 5 . tenia q ser 20%
        {
            Random aleatorio = new Random();
            if (aleatorio.Next(1, 5) == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public char validaSexo() // valido el sexo q meto en el constructor
        {
            if(Char.ToUpper(this.sexo)!='H' && Char.ToUpper(this.sexo) != 'M')
            {
                return 'H';
            }
            else
            {
                return Char.ToUpper(this.sexo);
            }
        }
        public override string ToString()
        {
            return "Nombre:" + this.nombre + ". Sexo: " + sexoCompleto(this.sexo) + ". Edad: " + this.edad + " años. Disponible: " + this.disponible ;
        }

    }
}
