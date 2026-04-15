/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:51:37
 * Version: 1.0.241
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
