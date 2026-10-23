/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 октября 2026 07:47:39
 * Version: 1.0.434
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
