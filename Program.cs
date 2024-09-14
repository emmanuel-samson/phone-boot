MobilePhone mobilePhone = new MobilePhone();


int option
do
{
    Console.WriteLine("\n Welcome To Mobile Phone Shop");
    Console.WriteLine("1. Add Mobile Phone");
    Console.WriteLine("2. View Mobile Phone");
    Console.WriteLine("3. Search Mobile Phone");
    Console.WriteLine("4. Exit");
    Console.WriteLine("Enter Your Option");
    option = int.Parse(Console.ReadLine());

    switch(option)
    {
        case 1:
        mobilePhone.addmobilephone();
        Console.WriteLine("New Mobile added successfully");
        break;

        case 2:
        mobilePhone.ViewMobilePhone();
        break;

        case 3:
        mobilePhone.SearchMobilePhone();
        break;
    }while (option !=4);

}
