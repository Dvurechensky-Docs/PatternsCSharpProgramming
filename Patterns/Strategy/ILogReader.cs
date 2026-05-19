/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 мая 2026 10:14:56
 * Version: 1.0.277
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
