namespace LisaKonveyer.Models
{
    public class Filial
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string? Address {get;set;}
        public string? Note {get;set;}
        public bool IsActive {get;set;} = true;
    }
}