/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 ноября 2026 11:42:21
 * Version: 1.0.452
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
