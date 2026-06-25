/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 июня 2026 16:29:55
 * Version: 1.0.314
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
