namespace calculatorSharp
{
    class Multiply : ICalcMethod
    {
        public double Var2 { get; }
        public string Name { get; }

        public Multiply(double var2)
        {
            Var2 = var2;
            Name = "Multiply";
        }
        public double calc(double var1)
        {
            return var1*Var2;
        }
        public void log()
        {
            Console.WriteLine(Name);
        }
    }
}