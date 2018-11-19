//Площадь прямоугольник
public void GetRectangleArea()
{
	Console.Write("Введите длину прямоугольника: ");
	int length = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите ширину прямоугольника: ");
	int width = Convert.ToInt32(Console.ReadLine());
	int area = length * width;
	Console.WriteLine("Площадь прямоугольника : {0}", area);
	Console.ReadKey();
}

//Площадь и периметр квадрата
public void GetSquareAreaAndPerimeter()
{
    Console.Write("Укажите сторону квадрата? :");
    int squareheight = Convert.ToInt32(Console.ReadLine());
    int area = squareheight * squareheight;
    int perimeter = 4 * squareheight;
    Console.WriteLine("Площадь : {0}\nПериметр : {1}", area, perimeter);
    Console.ReadKey();
}

//Количество слов в строке
public int GetCountOfWordInString(string value)
{
   string[] words = value.Split(' ');
   return words.Length;
}

//Последовательность Фибоначчи, 1 и 2 числа равны = 1, последующие суме двух предыдущих
public void Fib()
{
    int count = 10;
    int first = 1;
    int second = 1;
    Console.WriteLine("1 - {0}\n2 - {1}", first, second);
    for (int i = 2; i < count; i++)
    {
        int buf = second + first;
        first = second;
        second = buf;
        Console.WriteLine("{0} - {1}", i + 1, second);
    }
}

//Пример использования абстракного класа
//
//Базовый абстракный класс геометрических фигур
public abstract class GeometricShape
{
    public abstract int GetArea();

    public virtual string GetName()
    {
        return "Геометрическая фигура";
    }

}

//Класс квадрата
public class Square : GeometricShape
{
    private int width;

    public Square(int width)
    {
        this.width = width;
    }

    public override int GetArea()
    {
        return width * width;
    }

    public override string GetName()
    {
        return "Квадрат";
    }
}

//Класс прямоугольника
public class Rectangle : GeometricShape
{
    public int width;
    public int lenght;

    public Rectangle(int width, int lenght)
    {
        this.width = width;
        this.lenght = lenght;
    }

    public override int GetArea()
    {
        return width * lenght;
    }

    public override string GetName()
    {
        return "Прямоугольник";
    }
}

public void Test()
{
    int width = 5;
    int lenght = 3;
	//Создаем объект класса прямоугольник со сторонами 5 и 3
    GeometricShape rectangle = new Rectangle(width, lenght);
    Console.WriteLine("Площадь {0} - {1}", rectangle.GetName(), rectangle.GetArea());
	//Вывод: Площадь Прямоугольник - 15
	
	//Создаем объект класса квадрат со строной 5
    GeometricShape square = new Square(width);
    Console.WriteLine("Площадь {0} - {1}", square.GetName(), square.GetArea());
	//Вывод: Площадь Квадрат - 25
}