/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 октября 2026 09:51:53
 * Version: 1.0.430
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
