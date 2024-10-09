namespace calculatorSharp
{
    class Minus : ICalcMethod
    {
        public double Var2 { get; }
        public string Name { get; }

        public Minus(double var2)
        {
            Var2 = var2;
            Name = "Minus";
        }
        public double calc(double var1)
        {
            return var1-Var2;
        }
        public void log()
        {
            Console.WriteLine(Name);
        }
    }
}