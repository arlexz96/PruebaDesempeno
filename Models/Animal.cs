namespace PruebaC_sharp_ArlexZapata.Models;

public abstract class Animal{
  protected abstract int Id { get; set; }
  protected abstract string Name { get; set; }
  protected abstract DateOnly BirthDate { get; set; }
  protected abstract string Breed { get; set; }
  protected abstract string Color { get; set; }
  protected abstract double WeightInKg { get; set; }
  public Animal(string name, DateOnly birthDate, string breed, string color, double weight)
  {
    Name = name;
    BirthDate = birthDate;
    Breed = breed;
    Color = color;
    WeightInKg = weight;
  }
  public Animal(int id, string name, DateOnly birthDate, string breed, string color, double weight)
  {
    Id = id;
    Name = name;
    BirthDate = birthDate;
    Breed = breed;
    Color = color;
    WeightInKg = weight;
  }
  public abstract void ShowInformation();
  protected void BasicReview(){
  }
  protected int CalculateAgeInMonths(){
    return (DateTime.Today.Year - BirthDate.Year) * 12 + DateTime.Today.Month;
  }
}