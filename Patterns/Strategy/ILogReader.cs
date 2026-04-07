/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 апреля 2026 10:56:08
 * Version: 1.0.233
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
