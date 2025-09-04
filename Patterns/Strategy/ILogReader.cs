/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:09:05
 * Version: 1.0.18
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
