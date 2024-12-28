using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        // Метод для вычисления значения функции F(x)
        public static double CalculateFunction(double x)
        {
            double numerator = 5 * x + 2.5;  // Числитель первой части
            double denominator = Math.Sin(x) - 2; // Знаменатель первой части

            // Проверка деления на ноль
            double firstTerm = (denominator == 0) ? 0 : numerator / denominator;

            // Вторая часть функции
            double result = firstTerm + 2;

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
