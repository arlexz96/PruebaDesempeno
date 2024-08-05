using System.Drawing;

namespace PruebaC_sharp_ArlexZapata.Models;
public class VeterinaryClinic
{
  public string Name { get; set; }
  public string Address { get; set; }
  public List<Dog> Dogs { get; set; } = new List<Dog>(){
    new Dog(1, "Buddy", new DateOnly(2022, 01, 01), "Golden Retriever", "Golden", 4.5, true, "Timido", "123456789", "Largo", "Rizado"),
    new Dog(2, "Max", new DateOnly(2021, 12, 15), "Bulldog", "Blanco", 3.8, false, "Normal", "987654321", "Corto", "Duro")
  };
  public List<Cat> Cats { get; set; } = new List<Cat>(){
    new Cat(1, "Whiskers", new DateOnly(2022, 03, 10), "Persa", "Blanco", 2.5, true, "Pelo largo"),
    new Cat(2, "Fluffy", new DateOnly(2021, 08, 20), "Siamese", "Negro", 3.0, false, "Pelo corto")
  };
  public VeterinaryClinic()
  {
  }
  public VeterinaryClinic(string name, string address)
  {
    Name = name;
    Address = address;
  }
  public void SaveDog(Dog newDog)
  {
    Dogs.Add(newDog);
    Console.WriteLine("\nPerro Agregado Con Exito");
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void SaveCat(Cat newCat)
  {
    Cats.Add(newCat);
    Console.WriteLine("\nGato Agregado Con Exito");
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void UpdateDog()
  {
    int Id, opt;
    ShowAnimals("Dog");
    Console.WriteLine("Seleccione el id del animal que desea actualizar");
    Id = Convert.ToInt32(Console.ReadLine());
    foreach (var dog in Dogs)
    {
      if (dog.GetId() == Id)
      {
        Console.WriteLine("Perro Encontrado\n");
        Console.Write($@"ID:{dog.GetId()}
Nombre: {dog.GetName()} 
Raza: {dog.GetBreed()} 
Color: {dog.GetColor()}
Peso: {dog.GetWeightInKg()}Kg 
Castrado: {dog.BreedingStatus}
Temperamento: {dog.Temperament}
Numero Microship: {dog.MicrochipNumber}
Voumen de pelo: {dog.BarkVolume}

");

        Console.WriteLine(@"Seleccione la opcion que desea actualizar
1. Nombre
2. Fecha de nacimiento
3. Raza
4. Color
5. Peso en kg
6. Castrado
7. Temperamento
8. Numero de microship
9. Volumen de pelo");
      }
      opt = Convert.ToInt16(Console.ReadLine());
      switch (opt)
      {
        case 1:
          Console.Write("Ingrese el nuevo nombre: ");
          dog.SetName(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 2:
          Console.Write("Ingrese la nueva fecha de nacimiento (YYYY-MM-DD): ");
          dog.SetBirthDate(DateOnly.Parse(Console.ReadLine()));
          Console.Write("Dato Actualizado con exito");
          break;
        case 3:
          Console.Write("Ingrese la nueva raza: ");
          dog.SetBreed(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 4:
          Console.Write("Ingrese el nuevo color: ");
          dog.SetColor(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 5:
          Console.Write("Ingrese el nuevo peso en kg: ");
          dog.SetWeightInKg(Convert.ToDouble(Console.ReadLine()));
          Console.Write("Dato Actualizado con exito");
          break;
        case 6:
          Console.Write("Ingrese si el perro esta castrado (1. SI / 2. No) ");
          if (Convert.ToInt16(Console.ReadLine()) == 1)
          {
            dog.BreedingStatus = true;
          }
          else
          {
            dog.BreedingStatus = false;
          }
          Console.Write("Dato Actualizado con exito\n");
          break;
        case 7:
          Console.Write("Ingrese el nuevo temperamento: ");
          dog.Temperament = Console.ReadLine();
          Console.Write("Dato Actualizado con exito");
          break;
        case 8:
          Console.Write("Ingrese el nuevo numero de microship: ");
          dog.MicrochipNumber = Console.ReadLine();
          Console.Write("Dato Actualizado con exito");
          break;
        case 9:
          Console.Write("Ingrese el nuevo volumen de pelo: ");
          dog.BarkVolume = Console.ReadLine();
          Console.Write("Dato Actualizado con exito");
          break;
        default:
          Console.WriteLine("Opcion invalida");
          break;
      }
      break;
    }
    Console.WriteLine("Animal Actualizado Con Exito");
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void UpdateCat()
  {
    int Id, opt;
    ShowAnimals("Cat");
    Console.WriteLine("Seleccione el id del animal que desea actualizar");
    Id = Convert.ToInt32(Console.ReadLine());
    foreach (var catinfo in Cats)
    {
      if (catinfo.GetId() == Id)
      {
        Console.WriteLine("\nGato Encontrado\n");
        Console.Write($@"ID:{catinfo.GetId()}
Nombre: {catinfo.GetName()} 
Raza: {catinfo.GetBreed()} 
Color: {catinfo.GetColor()}
Peso: {catinfo.GetWeightInKg()}Kg 
Castrado: {catinfo.BreedingStatus}
Voumen de pelo: {catinfo.FurLength}

");

        Console.WriteLine(@"Seleccione la opcion que desea actualizar
1. Nombre
2. Fecha de nacimiento
3. Raza
4. Color
5. Peso en kg
6. Castrado
7. Volumen de pelo");
      }
      opt = Convert.ToInt16(Console.ReadLine());
      switch (opt)
      {
        case 1:
          Console.Write("Ingrese el nuevo nombre: ");
          catinfo.SetName(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 2:
          Console.Write("Ingrese la nueva fecha de nacimiento (YYYY-MM-DD): ");
          catinfo.SetBirthDate(DateOnly.Parse(Console.ReadLine()));
          Console.Write("Dato Actualizado con exito");
          break;
        case 3:
          Console.Write("Ingrese la nueva raza: ");
          catinfo.SetBreed(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 4:
          Console.Write("Ingrese el nuevo color: ");
          catinfo.SetColor(Console.ReadLine());
          Console.Write("Dato Actualizado con exito");
          break;
        case 5:
          Console.Write("Ingrese el nuevo peso en kg: ");
          catinfo.SetWeightInKg(Convert.ToDouble(Console.ReadLine()));
          Console.Write("Dato Actualizado con exito");
          break;
        case 6:
          Console.Write("Ingrese si el perro esta castrado (1. SI / 2. No) ");
          if (Convert.ToInt16(Console.ReadLine()) == 1)
          {
            catinfo.BreedingStatus = true;
          }
          else
          {
            catinfo.BreedingStatus = false;
          }
          Console.Write("Dato Actualizado con exito\n");
          break;
        case 7:
          Console.Write("Ingrese el nuevo volumen de pelo: ");
          catinfo.FurLength = Console.ReadLine();
          Console.Write("Dato Actualizado con exito");
          break;
        default:
          Console.WriteLine("Opcion invalida");
          break;
      }
      break;
    }
    Console.WriteLine("Animal Actualizado Con Exito");
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void DeleteDog()
  {
    int Id, opt;
    ShowAnimals("Dog");
    Console.WriteLine("Seleccione el id del animal que desea eliminar");
    Id = Convert.ToInt32(Console.ReadLine());
    foreach (var dog in Dogs)
    {
      if (dog.GetId() == Id)
      {
        Console.WriteLine("Perro Encontrado\n");
        Console.Write($@"ID:{dog.GetId()}
Nombre: {dog.GetName()} 
Raza: {dog.GetBreed()} 
Color: {dog.GetColor()}
Peso: {dog.GetWeightInKg()}Kg 
Castrado: {dog.BreedingStatus}
Temperamento: {dog.Temperament}
Numero Microship: {dog.MicrochipNumber}
Voumen de pelo: {dog.BarkVolume}

");
      }
      Console.WriteLine(@"Esta Seguro que desea eliminarlo? (1. Si / 2. No)");
      opt = Convert.ToInt16(Console.ReadLine());
      if (opt == 1)
      {
        Dogs.Remove(dog);
        Console.WriteLine("Animal Eliminado con exito");
        break;
      }
      else
      {
        Console.WriteLine("Operacion Cancelada");
        break;
      }
    }
    Console.WriteLine("Animal Eliminado Con Exito");
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void DeleteCat()
  {
    int Id, opt;
    ShowAnimals("Cat");
    Console.WriteLine("Seleccione el id del animal que desea eliminar");
    Id = Convert.ToInt32(Console.ReadLine());
    foreach (var catinfo in Cats)
    {
      if (catinfo.GetId() == Id)
      {
        Console.WriteLine("Gato Encontrado\n");
        Console.Write($@"ID:{catinfo.GetId()}
Nombre: {catinfo.GetName()} 
Raza: {catinfo.GetBreed()} 
Color: {catinfo.GetColor()}
Peso: {catinfo.GetWeightInKg()}Kg 
Castrado: {catinfo.BreedingStatus}
Voumen de pelo: {catinfo.FurLength}

");
      }
      Console.WriteLine(@"Esta Seguro que desea eliminarlo? (1. Si / 2. No)");
      opt = Convert.ToInt16(Console.ReadLine());
      if (opt == 1)
      {
        Cats.Remove(catinfo);
        Console.WriteLine("Animal Eliminado con exito");
        break;
      }
      else
      {
        Console.WriteLine("Operacion Cancelada");
        break;
      }
    }
    Console.WriteLine("Animal Eliminado Con Exito");
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void ShowAllPatients()
  {
    Console.WriteLine("Listado de Perros");
    ShowAnimals("Dog");
    Console.WriteLine("Listado de Gatos");
    ShowAnimals("Cat");
  }
  public void ShowAnimals(string type)
  {
    if (type == "Dog")
    {
      ManagerApp.ShowSeparator();
      Console.WriteLine("Id  | Nombre      | Raza             | Color        | Peso | Castrado | Temperamento | Numero Microship | Volumen Pelo");
      ManagerApp.ShowSeparator();
      foreach (var dog in Dogs)
      {
        Console.WriteLine($"{dog.GetId(),-4}| {dog.GetName(),-12}| {dog.GetBreed(),-17}| {dog.GetColor(),-13}| {dog.GetWeightInKg(),-5}| {dog.BreedingStatus,-9}| {dog.Temperament,-13}| {dog.MicrochipNumber,-18}| {dog.BarkVolume}");
      }
    }
    else
    {
      ManagerApp.ShowSeparator();
      Console.WriteLine("Id  | Nombre      | Raza             | Color        | Peso | Castrado | Volumen Pelo");
      ManagerApp.ShowSeparator();
      foreach (var cat in Cats)
      {
        Console.WriteLine($"{cat.GetId(),-4}| {cat.GetName(),-12}| {cat.GetBreed(),-17}| {cat.GetColor(),-13}| {cat.GetWeightInKg(),-5}| {cat.BreedingStatus,-9}| {cat.FurLength}");
      }
    }
    ManagerApp.ShowFooter();
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
  }
  public void ShowPatient(int idPatient)
  {
    Dog dog = Dogs.Find(x => x.GetId() == idPatient);
    Cat cat = Cats.Find(x => x.GetId() == idPatient);

    if (dog != null)
    {
      Console.WriteLine("Perro");
      Console.WriteLine("Id: " + dog.GetId());
      Console.WriteLine("Nombre: " + dog.GetName());
      Console.WriteLine("Raza: " + dog.GetBreed());
      Console.WriteLine("Color: " + dog.GetColor());
      Console.WriteLine("Peso: " + dog.GetWeightInKg() + "kg");
      Console.WriteLine("Castrado: " + (dog.BreedingStatus ? "Si" : "No"));
      Console.WriteLine("Temperamento: " + dog.Temperament);
      Console.WriteLine("Numero Microship: " + dog.MicrochipNumber);
      Console.WriteLine("Volumen de pelo: " + dog.BarkVolume);
    }
    else
    {
      Console.WriteLine("No se encontro ningun perro");
    }
    if (cat != null)
    {
      Console.WriteLine("\nGato");
      Console.WriteLine("Id: " + cat.GetId());
      Console.WriteLine("Nombre: " + cat.GetName());
      Console.WriteLine("Raza: " + cat.GetBreed());
      Console.WriteLine("Color: " + cat.GetColor());
      Console.WriteLine("Peso: " + cat.GetWeightInKg() + "kg");
      Console.WriteLine("Castrado: " + (cat.BreedingStatus ? "Si" : "No"));
      Console.WriteLine("Volumen de pelo: " + cat.FurLength);
    }
    else{
      Console.WriteLine("No se encontro ningun gato");
    }
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
  }
}