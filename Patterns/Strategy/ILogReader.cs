/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 февраля 2026 10:03:12
 * Version: 1.0.181
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
