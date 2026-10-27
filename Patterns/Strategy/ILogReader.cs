/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 октября 2026 06:51:46
 * Version: 1.0.438
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
