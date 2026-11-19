/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2026 07:45:00
 * Version: 1.0.461
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
