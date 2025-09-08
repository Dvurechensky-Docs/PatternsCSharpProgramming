/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 сентября 2025 13:12:15
 * Version: 1.0.22
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
