/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 июня 2026 15:15:52
 * Version: 1.0.292
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
