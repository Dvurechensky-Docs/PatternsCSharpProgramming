/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 июля 2026 10:59:38
 * Version: 1.0.337
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
