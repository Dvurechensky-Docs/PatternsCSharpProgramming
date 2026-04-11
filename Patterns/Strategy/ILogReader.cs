/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:38:52
 * Version: 1.0.237
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
