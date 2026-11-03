/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 ноября 2026 12:18:29
 * Version: 1.0.445
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
