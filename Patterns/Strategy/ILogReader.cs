/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2026 07:43:32
 * Version: 1.0.426
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
