using System;

/// <summary>
///  Refactorizacion: renombrar
///  El nombre no es nada intuitivo
/// </summary>
namespace ManejoNotas
{
    /// <summary>
    /// Refactorizacion general: Tabulación y Renombrar
    /// 
    /// Tabulación general, ya que el código estaba mal tabulado.
    /// He cambaido de varias variables el nombre, ya que no se deben
    /// de poner la primera mayúscula en las variables.
    /// 
    /// </summary>
    class Asignatura
    {
        ///<para>Refactorización: Encapsular campo, reordenar
        ///Reordenar, porque las variables de clase deben ser declaradas arriba del todo mejor, para no tener complicaciones
        ///futuras a la hora de añadir nuevos métodos
        ///Encapsular porque hace que las varaibles esten más controladas</para>
        public string codigodelaAsignatura { get; set; }
        public string nombredelaAsignatura { get; set; }
        public double notaGeneralTrimestre { get; set; }
        public double notaTrimestre { get; set; }
        public double notadelTercerTrimestre { get; set; }
        public double notaFinaldelCurso { get; set; }

        ///<para>Refactorización aplicada: Tabulación, Renombrar </para>
        ///<summary>
        ///<para>Constructor de Asignatura</para>
        /// </summary>
        public Asignatura(string codigodeAsignatura, string nombreAsignatura, double notaPrimertrimestre, double notaSegungoTrimestre, double notaTercerTrimestre, double notaFinalCurso)
        {
            codigodelaAsignatura = codigodeAsignatura; //Codigo de la asignatura.
            nombredelaAsignatura = nombreAsignatura; //Nombre de la asignatura.
                                                     // Nota de los trimestres (1, 2   y 3) y nota final.
            this.notaGeneralTrimestre = notaPrimertrimestre;
            this.notaTrimestre = notaSegungoTrimestre;
            this.notadelTercerTrimestre = notaTercerTrimestre;
            this.notaFinaldelCurso = notaFinalCurso;
        }


        ///<summary>
        /// Constructor de Materia
        /// <paramref name="nombreAsignatura"/></paramref>
        /// <paramref name="codAsignatura"/></paramref>
        /// </summary>
        public void IntroducirMateria(string codAsignatura, string nombreAsignatura)
        {
            this.codigodelaAsignatura = codAsignatura;
            this.nombredelaAsignatura = nombreAsignatura;
        }

        /// <summary>
        /// Imprime por pantalla las notasdelasPracticas y notasExamen segun la opcion que eligamos: 1, 2 o 3.
        /// </summary>
        /// <param name="notadelExamen1"></param>
        /// <param name="notadelExamen2"></param>
        /// <param name="notadelExamen3"></param>
        /// <param name="notadelasPracticas1"></param>
        /// <param name="notadelasPracticas2"></param>
        /// <param name="notadelasPracticas3"></param>
        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                    var Trimestre = Console.ReadLine();

                    switch (Trimestre)
                    {
                        case "1":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen1 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "2":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen2 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen3 = Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }
            }
        }


        ///<para> 
        /// Refactorizacion: Extraccion de metodo  
        /// Ya que se habia repetido 4 veces una funcion muy parecida
        /// También he tranformado el método en una línea 
        ///</para>

        ///<summary>
        /// Calcula la nota según la notadelExamen, la notadelaPracticas y la notaTrimestre
        /// del alumno.
        /// </summary>
        /// <param name="notadelasPracticas"></param>
        /// <param name="notadelExamen"></param>
        /// <returns> El resultado del calculo en double</returns>
        public double CalculoNota(double notadelExamen, double notadelasPracticas)
        {
            return (notadelExamen * 0.8) + (notadelasPracticas) * 0.2;
        }

    }

}
class ejemplodeunaAsignatura
{

//TODO
/*
 *   
static void main()
{
    * 
    * 
    * 
    asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");

    /
*/
}