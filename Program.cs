namespace LogicalPrograms
{
    class Program
    {
            
        public static void Main(string[] args)
        {
            fibonasi.CalculateFibonaciiSeries();
            PerfectNumber.CalculatePerfectNumber();
            ReverseNumber.Reverse();
            CuponNumbers.DinstinctCuponNumbers();
            PrimeNumber.CheckPrimeNumber();

            StopWatch stopwatch = new StopWatch();
            stopwatch.CollapseTime();
        }
    }
}