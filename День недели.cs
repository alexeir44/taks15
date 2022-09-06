// Инициализация переменных
string? UserInput;
string [] Week = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int i, number;

//начало программы
number = 7;
i = 0;

Console.WriteLine("Программа определяет день недели.\nДля ввода текущего дня используем сокращения:\n Понедельник - пн\n Вторник - вт\n Среда - ср\n Четверг - чт\n Пятница - пт\n Суббота - сб\n Воскресенье - вс");
Console.WriteLine ("Введите текущий день недели");

while(number==7)
{
    UserInput = Console.ReadLine();
    switch (UserInput)
    {
        case "пн":
            number = 0;
            break;
        case "вт":
            number = 1;
            break;
        case "ср":
            number = 2;
            break;
        case "чт":
            number = 3;
            break;
        case "пт":
            number = 4;
            break;
        case "сб":
            number = 5;
            break;
        case "вс":
            number = 6;
            break;
        default:
            Console.WriteLine("Неправильный ввод! Введите корректно день недели");
            break;
    }
}

Console.WriteLine("Через какое количество дней вы хотите узнать день недели? Вводить числом");
number += Convert.ToInt32(Console.ReadLine());
i = number%7;
Console.WriteLine("Это будет "+ Week[i]);