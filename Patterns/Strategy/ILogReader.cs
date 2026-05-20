/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:03:18
 * Version: 1.0.278
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
