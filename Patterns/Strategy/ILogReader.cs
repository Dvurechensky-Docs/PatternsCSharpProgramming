/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 мая 2026 11:42:24
 * Version: 1.0.284
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
