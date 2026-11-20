/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 ноября 2026 06:51:17
 * Version: 1.0.462
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
