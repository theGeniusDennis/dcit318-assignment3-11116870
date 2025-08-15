namespace ConsoleApplication.HealthcareSystem;

// Application layer for managing healthcare system
public class HealthSystemApp
{
    private readonly Repository<Patient> _patientRepo = new();
    private readonly Repository<Prescription> _prescriptionRepo = new();
    private Dictionary<int, List<Prescription>> _prescriptionMap = new();

    public void SeedData()
    {
        _patientRepo.Add(new Patient { Id = 1, Name = "John Doe", Age = 30, Gender = "Male" });
        _patientRepo.Add(new Patient { Id = 2, Name = "Jane Smith", Age = 25, Gender = "Female" });

        _prescriptionRepo.Add(new Prescription { Id = 1, PatientId = 1, MedicationName = "Ibuprofen", DateIssued = DateTime.Now });
        _prescriptionRepo.Add(new Prescription { Id = 2, PatientId = 1, MedicationName = "Paracetamol", DateIssued = DateTime.Now });
        _prescriptionRepo.Add(new Prescription { Id = 3, PatientId = 2, MedicationName = "Amoxicillin", DateIssued = DateTime.Now });
    }

    public void BuildPrescriptionMap()
    {
        _prescriptionMap = _prescriptionRepo.GetAll()
            .GroupBy(p => p.PatientId)
            .ToDictionary(g => g.Key, g => g.ToList());
    }

    public void PrintAllPatients()
    {
        foreach (var patient in _patientRepo.GetAll())
        {
            Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}");
        }
    }

    public void PrintPrescriptionsForPatient(int id)
    {
        if (_prescriptionMap.TryGetValue(id, out var prescriptions))
        {
            foreach (var prescription in prescriptions)
            {
                Console.WriteLine($"Medication: {prescription.MedicationName}, Date Issued: {prescription.DateIssued}");
            }
        }
        else
        {
            Console.WriteLine("No prescriptions found for the given patient ID.");
        }
    }
}
