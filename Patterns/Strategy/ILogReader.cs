/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 января 2026 06:51:56
 * Version: 1.0.165
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
