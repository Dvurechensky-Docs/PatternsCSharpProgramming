/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июня 2026 14:46:26
 * Version: 1.0.290
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
