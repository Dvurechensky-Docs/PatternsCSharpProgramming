/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 ноября 2026 06:51:40
 * Version: 1.0.449
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
