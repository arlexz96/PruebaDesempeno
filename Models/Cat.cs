namespace PruebaC_sharp_ArlexZapata.Models;

public class Cat : Animal
{
  protected override int Id { get; set; }
  protected override string Name { get; set; }
  protected override DateOnly BirthDate { get; set; }
  protected override string Breed { get; set; }
  protected override string Color { get; set; }
  protected override double WeightInKg { get; set; }
  public bool BreedingStatus { get; set; }
  public string FurLength { get; set; }
  public Cat(string name, DateOnly birthDate, string breed, string color, double weight, bool breedingstatus, string furlength) : base(name, birthDate, breed, color, weight)
  {
    BreedingStatus = breedingstatus;
    FurLength = furlength;
  }
  public Cat(int id,string name, DateOnly birthDate, string breed, string color, double weight, bool breedingstatus, string furlength) : base(id, name, birthDate, breed, color, weight)
  {
    Id = id;
    BreedingStatus = breedingstatus;
    FurLength = furlength;
  }
  public override void ShowInformation()
  {
    Console.WriteLine($"Id: {Id}, Name: {Name}, Birth Date: {BirthDate}, Breed: {Breed}, Color: {Color}, Weight: {WeightInKg} kg, Breeding Status: {BreedingStatus}, Fur Length: {FurLength}");
  }
  public void CastrateAnimal()
  {

  }
  public void Hairdress()
  {

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