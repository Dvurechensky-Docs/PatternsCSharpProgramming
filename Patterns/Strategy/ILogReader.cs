/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 сентября 2026 10:31:38
 * Version: 1.0.398
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
