/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 мая 2026 06:51:24
 * Version: 1.0.266
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
