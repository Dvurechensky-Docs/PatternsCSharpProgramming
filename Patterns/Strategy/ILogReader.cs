/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 января 2026 06:51:56
 * Version: 1.0.155
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
