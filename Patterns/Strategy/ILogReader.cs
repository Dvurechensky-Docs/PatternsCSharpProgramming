/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 июля 2026 13:29:58
 * Version: 1.0.341
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
