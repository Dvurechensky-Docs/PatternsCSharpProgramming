/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 апреля 2026 08:10:26
 * Version: 1.0.251
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
