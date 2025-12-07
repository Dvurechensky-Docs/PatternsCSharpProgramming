/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:56:49
 * Version: 1.0.112
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
