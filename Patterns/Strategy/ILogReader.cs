/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 января 2026 15:46:46
 * Version: 1.0.141
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
