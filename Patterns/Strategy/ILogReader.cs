/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 мая 2026 10:37:43
 * Version: 1.0.269
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
