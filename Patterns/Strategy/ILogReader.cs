/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 декабря 2025 15:34:58
 * Version: 1.0.111
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
