/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 мая 2026 15:26:31
 * Version: 1.0.265
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
