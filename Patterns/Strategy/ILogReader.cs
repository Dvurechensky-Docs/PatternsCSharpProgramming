/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2026 12:02:50
 * Version: 1.0.463
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
