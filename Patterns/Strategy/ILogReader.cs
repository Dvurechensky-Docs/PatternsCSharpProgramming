/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 июля 2026 14:13:02
 * Version: 1.0.336
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
