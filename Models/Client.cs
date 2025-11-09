using LisaKonveyer.Models;

namespace LisaKonveyer.Models
{
    public class Client
    {
        public int Id {get;set;}
        public int FilialId {get;set;}

        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        public string? MiddleName {get;set;}
        public string FullName => $"{LastName} {FirstName} {MiddleName}";
        public DateOnly? BornIn {get;set;}
        public string? PassportSerial {get;set;}
        public string? PassportPinfl {get;set;}
        public DateOnly? PassportGotDate {get;set;}
        public DateOnly? PassportExpireDate {get;set;}
        public string? PassportCountry {get;set;}
        public string? PassportRegion {get;set;}
        public Gender? Gender {get;set;}
        public Education? Education {get;set;}
        public string? Country {get;set;}
        public string? Region {get;set;}

        public string? GovCountry {get;set;}
        public string? GovRegion {get;set;}
        public string? GovCity {get;set;}
        public string? GovAddress {get;set;}

        public string? CurrentCountry {get;set;}
        public string? CurrentRegion {get;set;}
        public string? CurrentCity {get;set;}
        public string? CurrentAddress {get;set;}

        public string? Note {get;set;}

        public bool IsActive {get;set;} = true;

        public Filial Filial {get;set;}
    }

    public enum Gender{
        Male,
        Female
    }

    public enum Education{
        Educated,
        MidEducated,
        MidSpecial,
        NotEndedEducated,
        BeginnerEducated
    }
}