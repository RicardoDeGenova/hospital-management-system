namespace HospitalManagement.Model;

public enum Gender
{
    Male,
    Female
}

public enum MeasureType 
{
    Imperial,
    Metric
}

public enum HighestEducation
{
    None,
    PrimarySchool,
    MiddleSchool,
    HighSchoolOrGED,
    SomeCollege,
    College,
    MastersDegree,
    Doctorate,
}

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public int Height { get; set; }
    public MeasureType HeighType { get; set; }
    public int Weight { get; set; }
    public MeasureType WeightType { get; set; }
    public int FamilySize { get; set; }
    public HighestEducation HighestEducation { get; set; }
    public List<MedicalCondition> MedicalConditions { get; set; }
    public DateTime CreatedAt { get; set; }

    public string FullName => $"{FirstName} {LastName}";
    public int Age => DateTime.Now.Year - DateOfBirth.Year;
}
