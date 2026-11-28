/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2026 11:58:33
 * Version: 1.0.470
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
