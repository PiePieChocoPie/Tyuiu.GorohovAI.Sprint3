using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorohovAI.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double S = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                S += Math.Pow((1/(i + Math.Pow(value, i))), i);
            }
            return Math.Round(S, 3);
        }
    }
}
