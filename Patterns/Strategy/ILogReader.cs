/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:43:56
 * Version: 1.0.244
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
