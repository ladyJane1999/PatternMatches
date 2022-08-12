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
    vechicle = vechicle ?? throw new ArgumentNullException("null");

    if (vechicle is Car1 { engine1.power: < 100  } || vechicle is MotoSycele { engine1.power: < 100 }|| vechicle is Transport && isElectro)
    {
        Console.WriteLine(vechicle + " " + "Power is low");
        return true;
    }
    else if(vechicle is Car1 { engine1.power: > 100 } || vechicle is MotoSycele { engine1.power: > 100 })
    {
        Console.WriteLine(vechicle + " " + "Power ");
        return false;
    }
    else
    {
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
