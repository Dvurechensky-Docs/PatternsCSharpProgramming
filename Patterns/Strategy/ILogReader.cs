/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 июня 2026 07:20:47
 * Version: 1.0.319
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
