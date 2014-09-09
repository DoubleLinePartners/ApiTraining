namespace EdFi.Rest.Models
{
    public class EducationOrganizationInstitutionTelephone
    {
    	public string InstitutionTelephoneNumberType { get; set; }
    	
    	public string TelephoneNumber { get; set; }
    }

    public class EducationOrganizationIdentificationCode
    {
    	public string IdentificationCode { get; set; }
    	
    	public string EducationOrganizationIdentificationSystemType { get; set; }
    }

    public class EducationOrganizationCategory
    {
        public string Type { get; set; }
    }

    public class EducationOrganizationAddress
    {
    	public string AddressType { get; set; }
    	
    	public string City { get; set; }
    	
    	public string NameOfCounty { get; set; }
    	
    	public string PostalCode { get; set; }
    	
    	public string StateAbbreviationType { get; set; }
    	
    	public string StreetNumberName { get; set; }
    }
    
    public class EducationOrganizationInternationalAddress
    {
        public string AddressType { get; set; }
        
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }
        
        public string AddressLine3 { get; set; }
        
        public string AddressLine4 { get; set; }
        
        public string CountryType { get; set; }
    }
}

