namespace calculatorSharp
{
    class Division : ICalcMethod
    {
        public double Var2 { get; }
        public string Name { get; }

        public Division(double var2)
        {
            Var2 = var2;
            Name = "Division";
        }
        public double calc(double var1)
        {
            return var1/Var2;
        }

        public void log()
        {
            Console.WriteLine(Name);
        }
    }
}