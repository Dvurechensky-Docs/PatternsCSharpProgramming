/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 июля 2026 10:55:42
 * Version: 1.0.325
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
