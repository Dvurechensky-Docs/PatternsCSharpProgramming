/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 сентября 2026 09:17:37
 * Version: 1.0.404
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
