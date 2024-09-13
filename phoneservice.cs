public class phoneservice
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

         MobilePhone mobilePhone= new MobilePhone();
         mobilePhone.PhoneName = phoneName;
         mobilePhone.Storagecapacity= storageCapacity;
         mobilePhone.Colour= colour;

         phones.Add(mobilePhone);
         Console.WriteLine($" New Mobile Phone with Name {phoneName} {storageCapacity} {colour} sucessfully added");

    }
}