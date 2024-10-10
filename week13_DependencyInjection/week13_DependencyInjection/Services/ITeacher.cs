namespace week13_DependencyInjection.Services
{
    // Interface -> Bir sınıfın sahip olması gereken özellikleri ve metotları tanımlar, ancak nasıl uygulanacağı konusunda bir bilgi vermez.
    // ITeacher ->  Bu interface, "öğretmen" kavramını temsil eden ve bu kavramla ilgili temel operasyonları (adını almak, soyadını almak, bilgileri almak gibi)
    // tanımlayan bir sözleşme görevi görür.
    public interface ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        string GetInfo();   // Öğretmenin adını ve soyadını birleştirerek bir metin olarak döndürür.
    }
}
