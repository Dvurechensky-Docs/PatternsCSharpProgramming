/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2026 07:38:24
 * Version: 1.0.386
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
