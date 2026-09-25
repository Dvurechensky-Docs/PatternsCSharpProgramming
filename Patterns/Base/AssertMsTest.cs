/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 сентября 2026 09:34:37
 * Version: 1.0.407
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
