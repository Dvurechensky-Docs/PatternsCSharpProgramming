/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:34:03
 * Version: 1.0.119
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
