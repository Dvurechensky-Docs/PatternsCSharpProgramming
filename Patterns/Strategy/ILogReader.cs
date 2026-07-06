/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июля 2026 13:34:06
 * Version: 1.0.326
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
