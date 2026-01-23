/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 января 2026 07:56:14
 * Version: 1.0.159
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
