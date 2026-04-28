/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:25:05
 * Version: 1.0.255
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
