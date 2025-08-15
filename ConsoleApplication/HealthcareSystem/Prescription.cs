namespace ConsoleApplication.HealthcareSystem;

// Represents a prescription entity
public class Prescription
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public string MedicationName { get; set; } = string.Empty;
    public DateTime DateIssued { get; set; }
}
