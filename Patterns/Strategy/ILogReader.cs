/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 октября 2026 11:58:33
 * Version: 1.0.437
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
