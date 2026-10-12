/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2026 11:01:58
 * Version: 1.0.424
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
