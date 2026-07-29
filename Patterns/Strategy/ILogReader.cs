/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 июля 2026 15:44:20
 * Version: 1.0.349
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
