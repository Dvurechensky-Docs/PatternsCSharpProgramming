/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 ноября 2026 08:33:08
 * Version: 1.0.458
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
