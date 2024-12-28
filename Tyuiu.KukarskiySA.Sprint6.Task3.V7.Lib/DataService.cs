using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Создаем массив для хранения индексов строк и значений четвертого столбца
            var rowsWithFourthColumnValues = new List<(int[] row, int fourthColumnValue)>();

            // Заполняем список кортежами (строка, значение в четвертом столбце)
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }
                rowsWithFourthColumnValues.Add((row, matrix[i, 3]));
            }

            // Сортируем строки по значению в четвертом столбце
            rowsWithFourthColumnValues.Sort((x, y) => x.fourthColumnValue.CompareTo(y.fourthColumnValue));

            // Заполняем отсортированный массив
            for (int i = 0; i < rowsWithFourthColumnValues.Count; i++)
            {
                for (int j = 0; j < rowsWithFourthColumnValues[i].row.Length; j++)
                {
                    matrix[i, j] = rowsWithFourthColumnValues[i].row[j];
                }
            }

            return matrix;
        }

    }
}
