using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Указанный файл не найден.", path);
            }

            try
            {
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(path);

                // Преобразование строк в массив вещественных чисел
                List<double> numbers = new List<double>();
                foreach (string line in lines)
                {
                    if (double.TryParse(line, out double number))
                    {
                        // Округляем до трех знаков
                        numbers.Add(Math.Round(number, 3));
                    }
                }

                return numbers.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении данных из файла.", ex);
            }
        }
        // Метод для фильтрации чисел меньше 10
        public double[] FilterNumbersLessThan10(double[] numbers)
        {
            return numbers.Where(n => n < 10).ToArray();
        }

    }
}
