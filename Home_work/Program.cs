Console.Write("Введите номер задачи :");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 41:
        task41();
        break;

    case 43:
        task43();
        break;

    default:
        break;
}

dynamic Promt(string message)
    {
        Console.WriteLine(message);
        string value = Console.ReadLine();
        

        if(task == 43)
        {
            return Convert.ToDouble(value);
        }
        else
        {
            return Convert.ToInt32(value);
        }

    }


void task41()
{
    int[] InputArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Promt($"Введите {i + 1}-й элемент");
        }
        return array;
    }

    int CountPositiveNumbers(int[] array)
    {
        int count = 0;
        foreach(int num in array)
        {
            if(num > 0)
            {
                count++;
            }
        }
        return count;
    }

    int length = Promt("Введите колличество элементов >");
    int[] array;
    array = InputArray(length);
    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine($"Количество чисел больше 0 = {CountPositiveNumbers(array)}");

}


void task43()
{
    int COEFFICIENT = 0;
    int CONSTANT = 1;
    int X_COORD = 0;
    int Y_COORD = 0;
    int LINE1 = 1;
    int LINE2 = 2;

    double[] lineData1 = InputLineData(LINE1);
    double[] lineData2 = InputLineData(LINE2);

    if (ValidateLines(lineData1, lineData2))
    {
        double[] coord = FindCoords(lineData1, lineData2);
        Console.Write(@$"Точка пересечения уравнений 
        y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и 
        y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
        
        Console.WriteLine($"\nимеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
    }


    double[] InputLineData(int number)
    {
        double[] lineData = new double[2];
        lineData[COEFFICIENT] = Promt($"Введите коэффициент для {number} прямой > ");
        lineData[CONSTANT] = Promt($"Введите константу для {number} прямой > ");

        return lineData;
    }

    double[] FindCoords(double[] lineData1, double[] lineData2)
    {
        double[] coord = new double[2];
        coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
        coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];

        return coord;
    }

    bool ValidateLines(double[] lineData1, double[] lineData2)
    {
        if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
        {
            if (lineData1[CONSTANT] == lineData2[CONSTANT])
            {
                Console.WriteLine("Прямые совпадают");
                return false;
            }
            else
            {
                Console.WriteLine("Прямые параллельны");
                return false;
            }
        }
        return true;
    }
}
