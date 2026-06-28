/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июня 2026 11:42:04
 * Version: 1.0.317
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
