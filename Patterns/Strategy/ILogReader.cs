/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 декабря 2025 09:29:17
 * Version: 1.0.129
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
