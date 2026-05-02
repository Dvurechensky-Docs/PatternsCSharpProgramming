/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 мая 2026 19:16:05
 * Version: 1.0.260
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
