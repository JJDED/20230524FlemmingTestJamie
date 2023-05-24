using _20230524FlemmingTestJamie.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        Elephant elephant = new Elephant();
        var elephantitus = elephant.GetType();

        Console.WriteLine(elephantitus);
        Console.WriteLine($"{elephantitus.Name} is my class. \n");
            
        elephant.CreateDelete();

        //elephant.TwoToFive(); ikke færdig

        ///Exercise 4 // difference between a method and a class - det bliver på dansk nedenunder.
        /// <summary>
        /// 
        /// Forskellen mellem en metode og en klasse.
        /// Metode: En metode er en procedure hvori vi kan skrive en rækkekode, vi derefter kan kalde så den køre den specifikke kode der står i metoden.
        /// Det betyder at vi kan genbruge den samme kode igen og igen, men kalde den med få linjer kode.
        ///
        /// Klasse: 
        /// En klasse er så en datastruktur, som vi kan "gemme" vores metoder, funktioner, data, osv. i. 
        /// Det er også her vi kan gemme vores metoder, og senere kalde dem fra
        /// På den måde kan vi holde vores Main metode pæn.
        /// 
        /// </summary>
    }
}