/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 января 2026 06:52:00
 * Version: 1.0.157
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
