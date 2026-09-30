/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 сентября 2026 11:00:07
 * Version: 1.0.412
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
