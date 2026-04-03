/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:32:28
 * Version: 1.0.229
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
