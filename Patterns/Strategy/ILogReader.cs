/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:09
 * Version: 1.0.249
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
