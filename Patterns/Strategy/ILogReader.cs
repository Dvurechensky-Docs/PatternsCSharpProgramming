/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 декабря 2025 14:04:00
 * Version: 1.0.116
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
