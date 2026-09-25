/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 сентября 2026 09:34:37
 * Version: 1.0.407
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
