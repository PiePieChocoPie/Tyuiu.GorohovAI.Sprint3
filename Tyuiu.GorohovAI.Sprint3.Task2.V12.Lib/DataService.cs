using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorohovAI.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double P = 0;
            do
            {
                P *= Math.Pow(300.0 / (startValue + Math.Pow(value, startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(P,3);
        }
    }
}
