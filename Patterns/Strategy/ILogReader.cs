/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:14:20
 * Version: 1.0.42
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
