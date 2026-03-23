/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:10:56
 * Version: 1.0.218
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
