namespace calculatorSharp
{
    class Plus : ICalcMethod
    {
        public double Var2 { get; }
        public string Name { get; }

        public Plus(double var2)
        {
            Var2 = var2;
            Name = "Plus";
        }
        public double calc(double var1)
        {
            return var1+Var2;
        }
        public void log()
        {
            Console.WriteLine(Name);
        }
    }
}