/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:18:35
 * Version: 1.0.41
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
