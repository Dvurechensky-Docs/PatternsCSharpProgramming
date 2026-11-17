/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 ноября 2026 10:41:07
 * Version: 1.0.459
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
