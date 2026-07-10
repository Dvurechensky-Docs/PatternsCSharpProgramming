/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июля 2026 11:53:59
 * Version: 1.0.330
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
