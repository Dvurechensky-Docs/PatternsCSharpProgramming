/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:19:01
 * Version: 1.0.257
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
