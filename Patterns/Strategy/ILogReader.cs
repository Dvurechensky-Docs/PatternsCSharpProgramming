/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 июня 2026 13:13:12
 * Version: 1.0.316
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
