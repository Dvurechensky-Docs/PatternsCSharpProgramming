/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:07:02
 * Version: 1.0.113
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
