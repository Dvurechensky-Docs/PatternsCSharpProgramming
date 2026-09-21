/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 сентября 2026 09:33:54
 * Version: 1.0.403
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
