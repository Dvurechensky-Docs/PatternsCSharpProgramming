/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 июля 2026 12:55:28
 * Version: 1.0.343
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
