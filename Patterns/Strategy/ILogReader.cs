/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 ноября 2026 09:04:04
 * Version: 1.0.469
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
