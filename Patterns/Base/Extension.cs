/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 мая 2026 06:51:24
 * Version: 1.0.266
 */

namespace Base
{
    /// <summary>
    /// Тестовый класс статических реализаций
    /// </summary>
    internal static class Extension
    {
        /// <summary>
        /// Тестовый статический метод
        /// </summary>
        /// <param name="classMain">Представитель определённого поведения</param>
        public static void ResizeExt(this IInterTest classMain)
        {
            Console.WriteLine("Resize Class Extension");
        }
    }
}
