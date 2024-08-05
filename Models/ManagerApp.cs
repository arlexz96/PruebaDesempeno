using System.Formats.Asn1;

namespace PruebaC_sharp_ArlexZapata.Models;

public static class ManagerApp
{
  public static Dog CreateDog()
  {
    string Name = "", Breed = "", Color = "", Temperament = "", MicrochipNumber = "", BarkVolume = "", CoatType = "", Answer;
    bool BreedingStatus;
    DateOnly BirthDate;
    double WeightInKg;
    Dog newDog;
    Console.Write("Ingrese el nombre del perro: ");
    Name = Console.ReadLine();
    Console.Write("Ingrese la fecha de nacimiento del perro (AAAA/MM/DD): ");
    BirthDate = DateOnly.Parse(Console.ReadLine());
    Console.Write("Ingrese la raza del perro: ");
    Breed = Console.ReadLine();
    Console.Write("Ingrese el color del perro: ");
    Color = Console.ReadLine();


    do
    {
      try
      {
        Console.Write("Ingrese el peso en Kg del perro: ");
        WeightInKg = Convert.ToDouble(Console.ReadLine());
        if (WeightInKg <= 0)
        {
          Console.WriteLine("El peso del perro debe ser un numero positivo por favor intente de nuevo.");
        }
        else
        {
          break;
        }
      }
      catch (FormatException)
      {
        Console.Write("\nDato Invalido Por favor intente de nuevo!!!!!!!.\n");
      }
    } while (true);


    do
    {
      Console.Write(@"
¿El perro esta castrado? 
(1.Si / 2.No): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {

        if (Answer.Equals("1"))
        {
          BreedingStatus = true;
          break;
        }
        else if (Answer.Equals("2"))
        {
          BreedingStatus = false;
          break;
        }
        else
        {
          Console.WriteLine("\nPor favor ingrese un valor valido.");
        }
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    do
    {
      Console.Write(@"
Seleccione el temperamento del perro 
1. Timido 
2. Normal 
3. Agresivo): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {
        switch (Answer)
        {
          case "1":
            Temperament = "Timido";
            break;
          case "2":
            Temperament = "Normal";
            break;
          case "3":
            Temperament = "Agresivo";
            break;
          default:
            Console.WriteLine("\nPor favor ingrese un valor valido.");
            break;
        }
      }
      if (Temperament != "")
      {
        break;
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    do
    {
      Console.Write(@"
¿Tiene microchip? 
(1. Si / 2. No): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {
        switch (Answer)
        {
          case "1":
            Console.Write("Ingrese el numero de microship del perro: ");
            MicrochipNumber = Console.ReadLine();
            break;
          case "2":
            MicrochipNumber = "no aplica";
            break;
          default:
            Console.WriteLine("\nPor favor ingrese un valor valido.");
            break;
        }
      }
      if (MicrochipNumber != "")
      {
        break;
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    do
    {
      Console.Write(@"
Seleccione el valumen del pelo del perro 
1. Sin pelo 
2. Pelo corto 
3. Pelo mediano 
4. Pelo largo): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {
        switch (Answer)
        {
          case "1":
            BarkVolume = "sin pelo";
            break;
          case "2":
            BarkVolume = "pelo corto";
            break;
          case "3":
            BarkVolume = "pelo mediano";
            break;
          case "4":
            BarkVolume = "pelo largo";
            break;
          default:
            Console.WriteLine("\nPor favor ingrese un valor valido.");
            break;
        }
      }
      if (BarkVolume != "")
      {
        break;
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    do
    {
      Console.Write(@"
Seleccione el tipo de pelo del perro 
1. Duro 
2. Rizado 
3. Corto 
4. Largo: ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {
        switch (Answer)
        {
          case "1":
            CoatType = "duro";
            break;
          case "2":
            CoatType = "rizado";
            break;
          case "3":
            CoatType = "corto";
            break;
          case "4":
            CoatType = "largo";
            break;
          default:
            Console.WriteLine("\nPor favor ingrese un valor valido.");
            break;
        }
      }
      if (CoatType != "")
      {
        break;
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    newDog = new Dog(Name, BirthDate, Breed, Color, WeightInKg, BreedingStatus, Temperament, MicrochipNumber, BarkVolume, CoatType);
    return newDog;
  }
  public static Cat CreateCat()
  {
    string Name = "", Breed = "", Color = "", FurLength = "", Answer;
    bool BreedingStatus;
    DateOnly BirthDate;
    double WeightInKg;
    Cat newCat;
    Console.Write("Ingrese el nombre del gato: ");
    Name = Console.ReadLine();
    Console.Write("Ingrese la fecha de nacimiento del gato (AAAA/MM/DD): ");
    BirthDate = DateOnly.Parse(Console.ReadLine());
    Console.Write("Ingrese la raza del gato: ");
    Breed = Console.ReadLine();
    Console.Write("Ingrese el color del gato: ");
    Color = Console.ReadLine();

    do
    {
      try
      {
        Console.Write("Ingrese el peso en Kg del gato: ");
        WeightInKg = Convert.ToDouble(Console.ReadLine());
        if (WeightInKg <= 0)
        {
          Console.WriteLine("El peso del gato debe ser un numero positivo por favor intente de nuevo.");
        }
        else
        {
          break;
        }
      }
      catch (FormatException)
      {
        Console.Write("\nDato Invalido Por favor intente de nuevo!!!!!!!.\n");
      }
    } while (true);


    do
    {
      Console.Write(@"
¿El gato esta castrado? 
(1.Si / 2.No): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {

        if (Answer.Equals("1"))
        {
          BreedingStatus = true;
          break;
        }
        else if (Answer.Equals("2"))
        {
          BreedingStatus = false;
          break;
        }
        else
        {
          Console.WriteLine("\nPor favor ingrese un valor valido.");
        }
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    do
    {
      Console.Write(@"
Seleccione el volumen del pelo del gato 
1. Sin pelo 
2. Pelo corto 
3. Pelo mediano 
4. Pelo largo): ");
      Answer = Console.ReadLine();
      if (ValidateString(Answer))
      {
        switch (Answer)
        {
          case "1":
            FurLength = "sin pelo";
            break;
          case "2":
            FurLength = "pelo corto";
            break;
          case "3":
            FurLength = "pelo mediano";
            break;
          case "4":
            FurLength = "pelo largo";
            break;
          default:
            Console.WriteLine("\nPor favor ingrese un valor valido.");
            break;
        }
      }
      if (FurLength != "")
      {
        break;
      }
      else
      {
        Console.WriteLine("\nPor favor ingrese un valor valido.");
      }
    } while (true);

    newCat = new Cat(Name, BirthDate, Breed, Color, WeightInKg, BreedingStatus, FurLength);
    return newCat;
  }
  public static void ShowHeader()
  {
    ShowSeparator();
    Console.WriteLine("Clinica Veterinaria");
    ShowSeparator();
  }
  public static void ShowFooter()
  {
    ShowSeparator();
    Console.WriteLine("Developed by Arlex Zapata");
    ShowSeparator();
  }
  public static void ShowSeparator()
  {
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
  }
  public static bool ValidateString(string value)
  {
    bool Answer;
    if (String.IsNullOrEmpty(value))
    {
      Answer = false;
    }
    else
    {
      Answer = true;
    }
    return Answer;
  }
  public static void Menu()
  {
    int option;
    VeterinaryClinic v = new VeterinaryClinic();
    bool validInput = false;
    do
    {
      try
      {
        Console.Clear();
        Console.Write(@"
###############################################################################################
#                                        MENU                                                 #    
###############################################################################################

1. Agregar Perro.
2. Agregar Gato.
3. Actualizar Perro.
4. Actualizar Gato.
5. Borrar Perro.
6. Borrar Gato.
7. Mostrar Todos Los Pacientes.
8. Mostrar Todos Los Perros.
9. Mostrar Todos Los Gatos.
10. Mostrar Pacientes Dado Un Id.
0. Salir.

Selecciona una opcion: ");
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
          case 1:
            Console.Clear();
            Dog newDog = CreateDog();
            v.SaveDog(newDog);
            break;
          case 2:
            Console.Clear();
            Cat newCat = CreateCat();
            v.SaveCat(newCat);
            break;
          case 3:
            Console.Clear();
            v.UpdateDog();
            break;
          case 4:
            Console.Clear();
            v.UpdateCat();
            break;
          case 5:
            Console.Clear();
            v.DeleteDog();
            break;
          case 6:
            Console.Clear();
            v.DeleteCat();
            break;
          case 7:
            Console.Clear();
            v.ShowAllPatients();
            break;
          case 8:
            Console.Clear();
            v.ShowAnimals("Dog");
            break;
          case 9:
            Console.Clear();
            v.ShowAnimals("Cat");
            break;
          case 10:
            Console.Clear();
            Console.Write("Ingrese el id del paciente: ");
            int id = Convert.ToInt32(Console.ReadLine());
            v.ShowPatient(id);
            break;
          case 0:
            Console.WriteLine("Aplicacion finalizada con exito!");
            validInput = true;
            break;
          default:
            Console.WriteLine("Opción inválida, por favor intente de nuevo");
            break;
        }
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.Write("DATO INVALIDO POR FAVOR INTENTE DE NUEVO !!!!!!!.\n");
      }
    } while (!validInput);
  }
}