/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 января 2026 13:16:45
 * Version: 1.0.149
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
