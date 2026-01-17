/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 января 2026 11:57:04
 * Version: 1.0.153
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
