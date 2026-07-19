/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 июля 2026 09:59:52
 * Version: 1.0.339
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
