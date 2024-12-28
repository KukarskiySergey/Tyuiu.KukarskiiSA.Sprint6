using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        // Метод для вычисления значения функции F(x)
        public static double CalculateFunction(double x)
        {
            // Первая часть функции: cos(x) / x - 0.7
            double firstTerm = (x == 0) ? 0 : Math.Cos(x) / x - 0.7;

            // Вторая часть функции: -sin(x) * (12 * x + 2)
            double secondTerm = -Math.Sin(x) * (12 * x + 2);

            // Итоговое значение функции
            double result = firstTerm + secondTerm;

            // Округление до двух знаков после запятой
            return Math.Round(result, 2);
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Проверка на корректность диапазона
            if (stopValue < startValue)
            {
                throw new ArgumentException("Значение stopValue должно быть больше или равно startValue");
            }

            // Размер массива определяется количеством целых значений в диапазоне
            int size = stopValue - startValue + 1;
            double[] resultArray = new double[size];

            // Заполнение массива значениями функции
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                resultArray[i] = CalculateFunction(x);
            }

            return resultArray;
        }
    }
}
