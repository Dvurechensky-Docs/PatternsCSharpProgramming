/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 ноября 2026 11:28:43
 * Version: 1.0.454
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
