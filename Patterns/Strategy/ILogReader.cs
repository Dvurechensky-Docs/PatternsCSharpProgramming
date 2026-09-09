/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2026 06:51:42
 * Version: 1.0.391
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
