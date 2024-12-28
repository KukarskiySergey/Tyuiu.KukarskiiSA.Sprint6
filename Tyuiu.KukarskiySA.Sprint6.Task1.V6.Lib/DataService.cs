using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        // Метод для вычисления значения функции F(x)
        public static double CalculateFunction(double x)
        {
            double numerator = Math.Sin(x) - 2 * x; // Числитель первой части
            double denominator = 3 * x - 1;       // Знаменатель первой части

            // Проверка деления на ноль
            double firstTerm = (denominator == 0) ? 0 : numerator / denominator;

            // Вторая часть функции
            double secondTerm = Math.Sin(x) - 3 * x + 2;

            // Итоговое значение
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
