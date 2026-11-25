/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 ноября 2026 11:14:28
 * Version: 1.0.467
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
