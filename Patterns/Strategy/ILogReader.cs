/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 октября 2026 06:51:43
 * Version: 1.0.429
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
