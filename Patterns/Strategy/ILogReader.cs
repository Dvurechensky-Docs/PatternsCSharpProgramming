/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 мая 2026 15:42:28
 * Version: 1.0.288
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
