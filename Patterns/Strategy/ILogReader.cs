/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июля 2026 12:18:19
 * Version: 1.0.327
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
