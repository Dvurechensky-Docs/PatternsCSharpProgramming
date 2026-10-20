/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 октября 2026 06:51:55
 * Version: 1.0.431
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
