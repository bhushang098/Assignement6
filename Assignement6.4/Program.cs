class Vehicle

{

    public string brand = "Ford";

    public void honk()

    {

        Console.WriteLine("Tuut, tuut!");

    }

}

class Car : Vehicle 
{

    public string modelName = "Mustang";

}

class Program

{

    static void Main(string[] args)

    {

        Car myCar = new Car();

        Console.WriteLine("Brand of my Car : "+myCar.brand);

        Console.WriteLine("Model of My Car : " + myCar.modelName);
        
        myCar.honk();
    }

}
