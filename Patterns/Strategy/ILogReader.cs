/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 января 2026 11:24:33
 * Version: 1.0.144
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
