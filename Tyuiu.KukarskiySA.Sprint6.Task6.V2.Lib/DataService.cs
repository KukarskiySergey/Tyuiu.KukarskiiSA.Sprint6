using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KukarskiySA.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string str, string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                // Список для хранения вторых слов
                List<string> secondWords = new List<string>();

                // Обрабатываем каждую строку
                foreach (var line in lines)
                {
                    // Разделяем строку на слова, используя пробелы как разделитель
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Если есть хотя бы два слова, добавляем второе слово в список
                    if (words.Length > 1)
                    {
                        secondWords.Add(words[1]);
                    }
                }

                // Формируем результирующую строку
                return string.Join(" ", secondWords);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла.", ex);
            }
        }
    }
}
