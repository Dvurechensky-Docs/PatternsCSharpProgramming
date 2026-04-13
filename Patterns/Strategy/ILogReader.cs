/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:13
 * Version: 1.0.239
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
