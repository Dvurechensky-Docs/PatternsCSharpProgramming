/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 октября 2026 08:57:10
 * Version: 1.0.440
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
