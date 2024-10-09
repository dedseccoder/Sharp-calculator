namespace calculatorSharp
{
    public interface ICalcMethod 
    {
        public double Var2 { get; }
        public string Name { get; }
        public void log();
        public double calc(double var2);
    }
}