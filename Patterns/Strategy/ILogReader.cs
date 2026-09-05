/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2026 08:35:34
 * Version: 1.0.387
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
