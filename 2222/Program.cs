class Program
{
    static void Main(string[] args)
    {
         
        Bmw bmw = new Bmw();
        bmw.Model = "M5";
        bmw.TopSpeed = 600;
        bmw.Engine = 5.0;
        bmw.Km = 10000;
        bmw.Hp = 200;
        bmw.IsMpower = true;

        Mercedes mercedes = new Mercedes();
        mercedes.Model = "S-Class";
        mercedes.TopSpeed = 250;
        mercedes.Engine = 3.5;
        mercedes.Km = 500;
        mercedes.Hp = 450;
        mercedes.IsAmg = false;

        //Car car = new Car();
        //car.Model = "";
        //car.TopSpeed = 5;
        //car.Engine = 0.2;
        //car.Km = -100;
        //car.Hp = 2000;

    }
}
