/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 сентября 2026 08:45:03
 * Version: 1.0.401
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
