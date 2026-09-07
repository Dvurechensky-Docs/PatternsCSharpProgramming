/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2026 08:15:30
 * Version: 1.0.389
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
