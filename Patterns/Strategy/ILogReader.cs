/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 июля 2026 14:00:16
 * Version: 1.0.331
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
