/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:57:27
 * Version: 1.0.235
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
