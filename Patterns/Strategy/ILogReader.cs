/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:48:10
 * Version: 1.0.232
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
