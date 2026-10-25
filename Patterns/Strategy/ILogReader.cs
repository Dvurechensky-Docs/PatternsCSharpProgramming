/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2026 09:04:14
 * Version: 1.0.436
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
