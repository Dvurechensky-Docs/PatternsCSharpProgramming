/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 января 2026 16:24:15
 * Version: 1.0.137
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
