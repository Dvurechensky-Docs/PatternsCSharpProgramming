/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 июля 2026 11:53:21
 * Version: 1.0.335
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
