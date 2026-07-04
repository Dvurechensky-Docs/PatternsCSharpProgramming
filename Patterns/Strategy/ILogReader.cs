/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июля 2026 08:04:56
 * Version: 1.0.323
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
