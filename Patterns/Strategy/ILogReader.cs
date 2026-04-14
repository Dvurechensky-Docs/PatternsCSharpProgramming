/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:24:36
 * Version: 1.0.240
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
