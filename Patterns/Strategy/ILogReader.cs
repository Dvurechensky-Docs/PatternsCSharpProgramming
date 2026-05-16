/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 мая 2026 10:46:26
 * Version: 1.0.274
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
