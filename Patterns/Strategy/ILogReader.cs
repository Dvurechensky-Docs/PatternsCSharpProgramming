/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 мая 2026 06:51:44
 * Version: 1.0.258
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
