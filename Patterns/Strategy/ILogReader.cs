/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2026 09:14:38
 * Version: 1.0.453
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
