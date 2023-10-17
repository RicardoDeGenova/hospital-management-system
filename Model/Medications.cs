namespace HospitalManagement.Model;

public enum DosageType
{
    g,
    Mg,
    Ml,
    Drops,
}

public class Medications
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Dosage { get; set; }
    public DosageType DosageType { get; set; } 
}
