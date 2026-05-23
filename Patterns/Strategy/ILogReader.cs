/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 мая 2026 11:12:55
 * Version: 1.0.281
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
