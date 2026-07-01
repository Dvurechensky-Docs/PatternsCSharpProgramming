/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июля 2026 08:35:16
 * Version: 1.0.320
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
