/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 июля 2026 07:26:36
 * Version: 1.0.338
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
