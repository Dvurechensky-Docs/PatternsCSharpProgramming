/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2026 11:56:10
 * Version: 1.0.409
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
