using System;

class GaussSeidelMethod
{
    static double[] GaussSeidel(double x1, double x2, double epsilon, int maxIterations)
    {
        double[] result = new double[2];
        int iteration = 0;
        double prevX1, prevX2;

        do
        {
            prevX1 = x1;
            prevX2 = x2;

            // Уравнения системы
            x1 = (3.0 / 2.0) * Math.Cos(x2);
            x2 = Math.Sqrt((1+x1) / 9);

            iteration++;

            // Вывод результатов итерации
            Console.WriteLine($"Итерация {iteration}: x1 = {x1}, x2 = {x2}");

            // Проверка на достижение заданной точности
            if (Math.Abs(prevX1 - x1) < epsilon && Math.Abs(prevX2 - x2) < epsilon)
            {
                result[0] = x1;
                result[1] = x2;
                return result;
            }
        } while (iteration < maxIterations);

        // Если не удалось достичь точности за максимальное количество итераций
        Console.WriteLine("Не удалось достичь необходимой точности за пределами максимального числа итераций.");
        result[0] = x1;
        result[1] = x2;
        return result;
    }

    static void Main()
    {
        double x1 = 1, x2 = 1; // начальные приближения
        double epsilon = 0.01; // заданная точность
        int maxIterations = 1000; // максимальное количество итераций

        double[] result = GaussSeidel(x1, x2, epsilon, maxIterations);

        Console.WriteLine($"x1 = {result[0]}, x2 = {result[1]}");
    }
}
