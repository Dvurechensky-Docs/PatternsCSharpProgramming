/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июля 2026 15:10:38
 * Version: 1.0.346
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
