using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Aula
    {
        private int id;
        private int max_alumnos;
        private string materia;
        private string[] asig = { "Matemáticas", "Filosofía", "Física" };
        private Profesor profe; //el objeto aula tiene como atributo un objeto profe
        #region cons
        public Aula()
        {
            this.id = 0;
            this.max_alumnos = 0;
            this.materia = "";
        }

        public Aula(int id)
        {
            this.id = id;
            this.max_alumnos =0;
            this.materia = "";
        }
        public Aula(int id, int max_alumnos)
        {
            this.id = id;
            this.max_alumnos = max_alumnos;
            this.materia = "";
        }
        public Aula(int id, int max_alumnos, string materia)
        {
            this.id = id;
            this.max_alumnos = max_alumnos;
            this.materia = validarMateria(materia);
        }
        public Aula(int id, int max_alumnos, string materia,Profesor profe)
        {
            this.id = id;
            this.max_alumnos = max_alumnos;
            this.materia = validarMateria(materia);
            this.profe = profe;
        }
        #endregion

        #region getters
        public int Id { get => id; set => id = value; }
        public int Max_alumnos { get => max_alumnos; set => max_alumnos = value; }
        public string Materia { get => materia; set => materia = value; }
        public Profesor Profe { get => profe; set => profe = value; }
        #endregion

        public string validarMateria(string mat)
        {


            for (int i = 0; i < asig.Length; i++)
            {
                if (asig[i] == mat)
                {
                    return mat;
                }
            }

            return "Matemáticas";

        }
    }
}
