/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:03:51
 * Version: 1.0.231
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
