using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HospitalManagement.Model;

public enum Gender
{
    Male = 0,
    Female = 1
}

public enum MeasureType
{
    Imperial = 0,
    Metric = 1
}

public enum HighestEducation
{
    None = 0,
    PrimarySchool = 1,
    MiddleSchool = 2,
    HighSchoolOrGED = 3,
    SomeCollege = 4,
    College = 5,
    MastersDegree = 6,
    Doctorate = 7,
}

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public int Height { get; set; }
    public MeasureType HeighType { get; set; }
    public int Weight { get; set; }
    public MeasureType WeightType { get; set; }
    public int FamilySize { get; set; }
    public HighestEducation HighestEducation { get; set; }
    public List<MedicalCondition> MedicalConditions { get; set; } = new();
    public DateTime CreatedAt { get; set; }

    public string FullName => $"{FirstName} {LastName}";
    public int Age => DateTime.Now.Year - DateOfBirth.Year;

    public Address Address
    {
        get => default;
        set
        {
        }
    }
}
