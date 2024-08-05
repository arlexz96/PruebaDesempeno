
namespace PruebaC_sharp_ArlexZapata.Models;

public class Dog : Animal
{
  protected override int Id { get; set; }
  protected override string Name { get; set; }
  protected override DateOnly BirthDate { get; set; }
  protected override string Breed { get; set; }
  protected override string Color { get; set; }
  protected override double WeightInKg { get; set; }
  public bool BreedingStatus { get; set; }
  public string Temperament { get; set; }
  public string MicrochipNumber { get; set; }
  public string BarkVolume { get; set; }
  public string CoatType { get; set; }
  public Dog(string name, DateOnly birthDate, string breed, string color, double weight, bool breedingstatus, string temperament, string microchipnumber, string barkvolume, string coattype) : base(name, birthDate, breed, color, weight)
  {
    Id = GenerateId();
    BreedingStatus = breedingstatus;
    Temperament = temperament;
    MicrochipNumber = microchipnumber;
    BarkVolume = barkvolume;
    CoatType = coattype;
  }

  public Dog(int id, string name, DateOnly birthDate, string breed, string color, double weight, bool breedingstatus, string temperament, string microchipnumber, string barkvolume, string coattype) : base(id, name, birthDate, breed, color, weight)
  {
    Id = id;
    BreedingStatus = breedingstatus;
    Temperament = temperament;
    MicrochipNumber = microchipnumber;
    BarkVolume = barkvolume;
    CoatType = coattype;
  }

  public override void ShowInformation()
  {
    Console.WriteLine($"Id: {Id}, Name: {Name}, Birth Date: {BirthDate}, Breed: {Breed}, Color: {Color}, Weight: {WeightInKg} kg, Breeding Status: {BreedingStatus}, Temperament: {Temperament}, Microchip Number: {MicrochipNumber}, Bark Volume: {BarkVolume}, Coat Type: {CoatType}");
  }
  public void CastrateAnimal(){

  }
  public void Hairdress(){

  }
  public static int GenerateId(){
    int Id;
    VeterinaryClinic v = new VeterinaryClinic();
    Id = v.Dogs.Max(m => m.Id);
    return Id + 1;
  }

    public int GetId()
  {
    return Id;
  }
  public void SetId(int value)
  {
    Id = value;
  }
  public string GetName()
  {
    return Name;
  }
  public void SetName(string value)
  {
    Name = value;
  }
  public DateOnly GetBirthDate()
  {
    return BirthDate;
  }
  public void SetBirthDate(DateOnly value)
  {
    BirthDate = value;
  }
  public string GetBreed()
  {
    return Breed;
  }
  public void SetBreed(string value)
  {
    Breed = value;
  }
  public string GetColor()
  {
    return Color;
  }
  public void SetColor(string value)
  {
    Color = value;
  }
  public double GetWeightInKg()
  {
    return WeightInKg;
  }
  public void SetWeightInKg(double value)
  {
    WeightInKg = value;
  }
}