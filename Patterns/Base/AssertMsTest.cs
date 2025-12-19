/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 декабря 2025 06:51:57
 * Version: 1.0.124
 */

namespace Base;

public class AssertMsTest
{
    /// <summary>
    /// Получить квадратный корень
    /// </summary>
    /// <param name="value">Значение</param>
    /// <returns>double</returns>
    public static double GetSqrt(double value)
    {
        return Math.Sqrt(value);
    }

    /// <summary>
    /// Получить приветствие
    /// </summary>
    /// <param name="name">Имя</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">пустое имя</exception>
    public string SayHello(string name)
    {
        if (name == null) throw new ArgumentNullException("Parameter name can not be null");
        return "Hi! " + name; 
    }
}
