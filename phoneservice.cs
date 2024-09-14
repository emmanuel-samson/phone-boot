using System.Dynamic;

public class PhoneService
{
    List<MobilePhone> phones = new List<MobilePhone>();
    
    public void AddPhone()
    {
        Console.WriteLine("Enter the name of the Phone");
        string phoneName = Console.ReadLine();
        Console.WriteLine("Enter the Storage Capacity of the Phone");
        int storageCapacity = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the Colour of the Phone");
        string colour = Console.ReadLine();

         MobilePhone mobilePhone = new MobilePhone();
         mobilePhone.PhoneName = phoneName;
         mobilePhone.Storagecapacity = storageCapacity;
         mobilePhone.Colour = colour;

         phones.Add(mobilePhone);
         Console.WriteLine($" New Mobile Phone with Name {phoneName} {storageCapacity} {colour} sucessfully added");

    }
}
Public void ViewMobilePhone()
{
    foreach (var mobilePhone in Phones)
    {
        Console.WriteLine ($"{mobilePhone.PhoneName} {mobilePhone.Storagecapacity} {mobilePhone.Colour}");
    }
}

public void SearchMobilePhone
{
    Console.WriteLine("Enter the PhoneName");
    string phoneName = Console.ReadLine();
    Console.WriteLine ("Enter the Storage Capacity of the Phone");
    int storagecapacity = int.Parse (Console.ReadLine());
    Console.WriteLine ("Enter the colour of the Phone");
    string colour= Console.ReadLine();
    List<MobilePhone> phones = new List<MobilePhone>();

    foreach (var mobilePhone in Phones)
    {
        if (mobilePhone.PhoneName == PhoneName && mobilePhone.Storagecapacity == storagecapacity && mobilePhone.Colour == colour)
        {
            availablePhones.Add(mobilePhone);
        }
    }
    if (availablePhones.Count > 0) 
    {
        foreach ( var mobilePhone in availablePhones)
        {
            Console.WriteLine ($"{mobilePhone.PhoneName} {mobilePhone.Storagecapacity} {mobilePhone.Colour}");
        }
    }    
    else
    {
        Console.WriteLine (" No Mobile Phone found");
    }
}

