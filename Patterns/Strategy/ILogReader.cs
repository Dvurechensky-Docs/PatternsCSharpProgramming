/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 сентября 2026 09:40:12
 * Version: 1.0.411
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
