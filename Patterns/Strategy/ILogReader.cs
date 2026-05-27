/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 мая 2026 13:03:37
 * Version: 1.0.285
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
