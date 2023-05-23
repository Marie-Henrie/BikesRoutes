using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Liikunta.Models;

public class City
{
    public int Id { get; set; }
    public int FID { get; set; }

    public string? Nimi { get; set; }

    public string? Namn { get; set; }

    public string? Name { get; set; }
    public string? Osoite { get; set; }

    public string? Adress { get; set; }
    public string? Kaupunki { get; set; }

    public string? Stad { get; set; }
    public string? Operaattor { get; set; }


    public int? Kapasiteet { get; set; }
   

    public float? x { get; set; }
    public float? y { get; set; }


}

     
