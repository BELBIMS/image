using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new();       // Создаем экземпляр класса HttpClient для выполнения HTTP-запросов
        Console.WriteLine("Введите ссылку для скачивания картинки: ");
        string nameWebsite = Console.ReadLine();                // Запрашиваем у пользователя ссылку для скачивания картинки
        HttpResponseMessage response = await client.GetAsync(nameWebsite);         // Выполняем асинхронный HTTP-запрос и получаем ответ
        byte[] data = await response.Content.ReadAsByteArrayAsync();       // Считываем данные из ответа в байтовый массив
        await File.WriteAllBytesAsync("C:\\Users\\Пользователь\\Desktop\\b.jpg", data);            // Записываем данные в файл "C:\\Users\\Пользователь\\Desktop\\b.jpg"
        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Пользователь\\Desktop\\b.jpg", UseShellExecute = true });        // Открываем сохраненный файл с помощью процесса
    }
}
