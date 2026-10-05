/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 октября 2026 08:11:01
 * Version: 1.0.417
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
