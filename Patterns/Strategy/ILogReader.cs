/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 мая 2026 17:29:50
 * Version: 1.0.286
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
