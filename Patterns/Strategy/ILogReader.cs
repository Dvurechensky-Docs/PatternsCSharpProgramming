/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2026 12:04:53
 * Version: 1.0.270
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
