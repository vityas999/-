// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int Coficient = 0;
const int Constanta = 1;
const int xCoord = 0;
const int yCoord = 1;
const int line1 = 1;
const int line2 = 2;
double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if(ValidateLine(lineData1, lineData2))
{
    double[] coord = CoordFind(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[Coficient]} * x + {lineData1[Constanta]} и y = {lineData2[Coficient]} * x + {lineData2[Constanta]}");
    Console.WriteLine($"имеет кординаты ({coord[xCoord]}), {coord[yCoord]}");
}

double Input(string massage)

{
    Console.Write(massage);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coficient] = Input($"Введите коффициент для {numberOfLine} - й для прямой > ");
    lineData[Constanta] = Input($"Введите константу для {numberOfLine} - й для прямой > ");
    return lineData;
}

double[] CoordFind(double[] lineData1, double[] lineData2 )
{
    double[] coord = new double[2];
    coord[xCoord] = (lineData1[Constanta] - lineData2[Constanta]) / (lineData2[Coficient] - lineData1[Coficient]);
    coord[yCoord] = lineData1[Constanta] * coord[xCoord] + lineData1[Constanta];
    return coord;
}

bool ValidateLine(double[] lineData1, double[] lineData2)
{
    if(lineData1[Coficient] == lineData2[Coficient])
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    return true;
}
