/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 мая 2026 06:51:42
 * Version: 1.0.282
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
