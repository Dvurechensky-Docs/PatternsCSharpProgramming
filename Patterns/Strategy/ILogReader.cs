/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 мая 2026 06:51:41
 * Version: 1.0.261
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
