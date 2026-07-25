/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 июля 2026 14:28:57
 * Version: 1.0.345
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
