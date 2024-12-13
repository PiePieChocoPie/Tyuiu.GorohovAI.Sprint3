using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorohovAI.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S =0;
            for (int k = startValue; k <= stopValue; k++)
            {
                S += (Math.Pow(value, k) + 1.0 / 4) * Math.Sin(k);
            }

            // Вывод результат
            return S;
        }
    }
}
