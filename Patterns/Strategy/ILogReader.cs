/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 июня 2026 13:25:35
 * Version: 1.0.300
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
