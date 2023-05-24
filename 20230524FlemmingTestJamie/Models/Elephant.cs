using System.Data.SqlTypes;

namespace _20230524FlemmingTestJamie.Models;
//Exercise 1
public class Elephant : Animal
{
    //Exercise 3
    public void CreateDelete()
    {
        Elephant elephant = new Elephant();
        var elephantitus = elephant.GetType();
                
        Console.Write("Create or Delete: ");
        var createOrDelete = Console.ReadLine().ToLower();
        var sql = "";
        if (createOrDelete.Equals("create"))
        {
            Console.Write("Insert ID: ");
            string elephantID = Console.ReadLine();
            Console.Write("Insert name: ");
            string elephantName = Console.ReadLine();
            Console.Write("Insert age: ");
            string elephantAge = Console.ReadLine();
            Console.Write("African or Indian: ");
            string elephantRace = Console.ReadLine().ToLower();

            if (elephantRace.Equals("african"))
            {
                sql = $"insert into {elephantitus.Name} values('{elephantID}','{elephantName}', '{elephantAge}', '{elephantRace}')";
            }
            else if (elephantRace.Equals("indian"))
            {
                Console.WriteLine("Cannot insert indian elephants to database. Restarting.\n");
                CreateDelete();
            }
            else
            {
                Console.WriteLine("Wrong input. Restarting. \n");
                CreateDelete();
            }
            Console.WriteLine($"Here is my query: {sql}");
        }
        else if (createOrDelete.Equals("delete"))
        { 
            Console.Write("Delete ID: ");
            var elephantID = Convert.ToInt32(Console.ReadLine());
            sql = $"delete from {elephantitus.Name} where ID='{elephantID}'";
            Console.WriteLine($"Here is my query: {sql}");
        }
        else
        {
            Console.WriteLine("Wrong input. Restarting. \n");
            CreateDelete();
        }
    }
    //Exercise 6 -- Ikke færdig, nåede ikke videre med den.
    public void TwoToFive()
    {
        Elephant elephant = new Elephant();
        var elephantitus = elephant.GetType();
        var sql = "";

        Console.WriteLine("Insert between 2 and 5 queries.");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Insert ID: ");
            string elephantID = Console.ReadLine();
            Console.Write("Insert name: ");
            string elephantName = Console.ReadLine();
            Console.Write("Insert age: ");
            string elephantAge = Console.ReadLine();
            Console.Write("African or Indian: ");
            string elephantRace = Console.ReadLine().ToLower();

            if (elephantRace.Equals("african"))
            {
                sql = $"insert into {elephantitus.Name} values('{elephantID}','{elephantName}', '{elephantAge}', '{elephantRace}')";
                
            }
            else if (elephantRace.Equals("indian"))
            {
                Console.WriteLine("Cannot insert indian elephants to database. Restarting.\n");
                TwoToFive();
            }
            else
            {
                Console.WriteLine("Wrong input. Restarting. \n");
                TwoToFive();
            }
            Console.WriteLine($"Here is my query: {sql}");
        }
        
    }
}
