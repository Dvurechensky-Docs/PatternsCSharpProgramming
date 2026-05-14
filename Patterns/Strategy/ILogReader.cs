/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 мая 2026 10:36:32
 * Version: 1.0.272
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
