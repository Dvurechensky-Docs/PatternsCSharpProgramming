/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:47:14
 * Version: 1.0.295
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
