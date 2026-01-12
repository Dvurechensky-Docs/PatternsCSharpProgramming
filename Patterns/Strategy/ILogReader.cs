/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 января 2026 06:52:01
 * Version: 1.0.148
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
