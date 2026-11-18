/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 ноября 2026 06:51:22
 * Version: 1.0.460
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
