using LisaKonveyer.Models;
using LisaKonveyer.Data;

namespace LisaKonveyer.Models
{
    public class Loan
    {
        public int Id {get;set;}
        public int FilialId {get;set;}
        public int ApplicationId {get;set;}
        public int ClientId {get;set;}
        public string UserId {get;set;} = string.Empty;

        public int Amount {get;set;}
        public DateOnly StartDate => DateOnly.FromDateTime(DateTime.Now);
        public DateOnly EndDate {get;set;}
        public int PayDay {get;set;}
        public int InterestRate {get;set;}
        public string ContractId {get;set;}

        public string? Note {get;set;}

        public Filial Filial {get;set;}
        public Application Application {get;set;}
        public Client Client {get;set;}
        public ApplicationUser User {get;set;}

        public bool IsActive {get;set;} = true;
    }
}