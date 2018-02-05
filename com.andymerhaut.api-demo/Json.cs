
/// <summary>
/// This is auto-generated when you paste JSON as classes.
/// It was originally called Rootobject
/// </summary>
public class ProviderResult//Rootobject
{
    public Provider[] Result { get; set; }
}


/// <summary>
/// Our POCO we use as a schema to create a database table and deserialize
/// JSON response from web service.
/// </summary>
public class Provider //Class1
{
    public int ProviderId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string LocationName { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string CityStatePostalCode { get; set; }
    public string PhoneReception { get; set; }
    public string Specialty { get; set; }
    public string LocationsIn { get; set; }
    public decimal Distance { get; set; }
    public bool IsBpp { get; set; }
    public bool IsEmployed { get; set; }
    public object ExistingPatientURL { get; set; }
    public object NewPatientURL { get; set; }
}
