/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:30:39
 * Version: 1.0.130
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
