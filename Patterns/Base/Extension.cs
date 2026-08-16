/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 августа 2026 14:23:59
 * Version: 1.0.367
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
