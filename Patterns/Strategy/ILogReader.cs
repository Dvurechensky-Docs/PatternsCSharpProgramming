/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2026 12:07:58
 * Version: 1.0.410
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
