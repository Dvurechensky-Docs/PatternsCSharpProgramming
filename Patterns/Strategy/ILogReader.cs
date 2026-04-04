/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:58:55
 * Version: 1.0.230
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
