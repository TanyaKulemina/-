//Запрашиваем текст от пользователя и сохраняем его в переменную
Console.WriteLine("Введите текст");
string text = Console.ReadLine();

//Разделяем текст по словам и оздаем массив строк
string[] arrWords = text.Split(' ');

//Создать метод, выбирающий слова из 3-ъ и менее символов
void Select(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string word = array[i].ToString();
        if (word.Length <= 3)
            {
                Console.Write($"{array[i]}, ");
            }
    } 
}


