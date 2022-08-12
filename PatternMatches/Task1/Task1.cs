using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatches
{
    // Records for Task1
    public record Transport;
    public record Engine1(int power);
    public record Car1(Engine1 engine1) : Transport;
    public record MotoSycele(Engine1 engine1) : Transport;
    public record SmartCar(bool isLowPowerVechicle);
}
