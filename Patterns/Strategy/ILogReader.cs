/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 сентября 2026 09:36:21
 * Version: 1.0.406
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
