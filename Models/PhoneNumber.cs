using LisaKonveyer.Models;

namespace LisaKonveyer.Models
{
    public class PhoneNumber
    {
        public int Id {get;set;}
        public int ClientId {get;set;}

        public string Name {get;set;}
        public string Number {get;set;}

        public Client Client {get;set;}
    }
}