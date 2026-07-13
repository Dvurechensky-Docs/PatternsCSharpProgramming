/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 июля 2026 06:51:47
 * Version: 1.0.333
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
