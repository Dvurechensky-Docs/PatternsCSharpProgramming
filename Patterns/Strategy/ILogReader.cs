/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 декабря 2025 13:33:27
 * Version: 1.0.114
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
