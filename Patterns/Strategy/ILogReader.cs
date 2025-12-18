/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 декабря 2025 06:51:55
 * Version: 1.0.123
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
