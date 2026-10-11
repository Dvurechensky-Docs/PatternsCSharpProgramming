/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2026 11:51:06
 * Version: 1.0.423
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
