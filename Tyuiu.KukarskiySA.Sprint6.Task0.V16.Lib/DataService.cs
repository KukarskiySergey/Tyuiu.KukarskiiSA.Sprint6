using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint6Task0V16
    {
        public double Calculate(int x)
        {
            // Формула расчета
            double result = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);

            // Округление до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}
