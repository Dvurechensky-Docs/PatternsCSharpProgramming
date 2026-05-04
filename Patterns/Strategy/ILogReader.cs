/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 мая 2026 06:51:46
 * Version: 1.0.262
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
