using PatternMatches;

// Task
object obj = new Car(new Engine(105));

var isCarWith105PH = obj is Car;

if (obj is Car)
{

    var o1 = obj as Car;

    Console.WriteLine(o1);
}

Console.WriteLine(isCarWith105PH);

// Task 1

static bool isLowPowerVechicle(object vechicle, bool isElectro)
    {
    
    switch (vechicle)
        {
            case Transport motoSycele when isElectro:

            Console.WriteLine("Electtro");

            return true;

        case Car1 car1:

            var v = vechicle as Car1;

            return v.engine1.power < 100;

        case MotoSycele motoSycele:

            var m = vechicle as MotoSycele;

            return m.engine1.power < 100;

        case null:
                throw new ArgumentNullException("Null");
              
            default:
                throw new ArgumentException("Invalid object");
               
        }
      
    }


    object obj2 = new MotoSycele(new Engine1(90));
    object obj1 = new Car1(new Engine1(190));
    object obj3 = new SmartCar(isLowPowerVechicle(obj1, true));

    var isPower1 = isLowPowerVechicle(obj1, false);
    var isPower2 = isLowPowerVechicle(obj2, false);
try
{
    var isLowPower = isLowPowerVechicle(42, false);
}
catch (ArgumentException ex)
{
    Console.Write(ex.Message); 
}