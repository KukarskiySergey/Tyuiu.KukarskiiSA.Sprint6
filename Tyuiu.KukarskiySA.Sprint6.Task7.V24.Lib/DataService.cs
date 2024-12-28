using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) < 2)
            {
                throw new ArgumentException("Матрица должна содержать как минимум две строки.");
            }

            // Получаем количество столбцов
            int columns = matrix.GetLength(1);

            // Проходим по второй строке матрицы
            for (int j = 0; j < columns; j++)
            {
                // Проверяем, является ли элемент четным
                if (matrix[1, j] % 2 == 0)
                {
                    // Заменяем четные элементы на 1
                    matrix[1, j] = 1;
                }
            }

            // Возвращаем модифицированную матрицу
            return matrix;
        }
    }
}
