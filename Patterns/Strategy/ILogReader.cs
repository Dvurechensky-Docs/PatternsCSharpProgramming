/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 июня 2026 15:54:07
 * Version: 1.0.312
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
