using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230524FlemmingTestJamie.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Race { get; set; }
    public string connectingString { get; set; } = @"Server=(LocalDB)\MSSQLLocalDB;Database=h1Tutorial001; Trusted_Connection=true; TrustServerCertificate=true;";

    public void create()
    {

    }
}
