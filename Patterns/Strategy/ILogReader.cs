/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 ноября 2026 06:51:20
 * Version: 1.0.465
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
