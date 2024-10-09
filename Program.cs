using System.Numerics;
using System.Runtime.CompilerServices;
using calculatorSharp;


List<ICalcMethod> procedureSort(List<ICalcMethod> methods)
{
    List<ICalcMethod> swap = new List<ICalcMethod>();
    try
    {
        for(int i = 0; i < methods.Count(); i++){
            if((methods[i].Name == "Multiply" || methods[i].Name == "Division") && i != 0){
                swap.Add(methods[i-1]);
                swap.Add(methods[i]);
                methods.RemoveAt(i);
                methods.RemoveAt(i-1);
            }
        }
    }
    catch
    {
        Console.WriteLine("Sorting failed.");
    }

    swap.AddRange(methods);

    return swap;
}

List<ICalcMethod> methods = new List<ICalcMethod>();
bool loopContinue = true;

while(loopContinue)
{
    Console.WriteLine("1. Плюс");
    Console.WriteLine("2. Минус");
    Console.WriteLine("3. Умножить");
    Console.WriteLine("4. Делить");
    Console.WriteLine("5. Посчитать");
    Console.Write("Выберите операцию: ");
    double doubleInput = Convert.ToDouble(Console.ReadLine());
    switch(doubleInput)
    {
        case 1:
            Console.Write("Введите число: ");
            double var2Input = Convert.ToDouble(Console.ReadLine());
            methods.Add(new Plus(var2Input));
            break;
        case 2:
            Console.Write("Введите число: ");
            var2Input = Convert.ToDouble(Console.ReadLine());
            methods.Add(new Minus(var2Input));
            break;
        case 3:
            Console.Write("Введите число: ");
            var2Input = Convert.ToDouble(Console.ReadLine());
            methods.Add(new Multiply(var2Input));
            break;
        case 4:
            Console.Write("Введите число: ");
            var2Input = Convert.ToDouble(Console.ReadLine());
            methods.Add(new Division(var2Input));
            break;
        case 5:
            loopContinue = false;
            break;
        default:
            Console.WriteLine("Выбрано неверное значение");
            break;
    }
}

methods = procedureSort(methods);

double sum = 0;
for(int i = 0; i < methods.Count; i++){
    sum = methods[i].calc(sum);
}
Console.WriteLine("Сумма: " + sum);
