/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2026 06:51:47
 * Version: 1.0.394
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
