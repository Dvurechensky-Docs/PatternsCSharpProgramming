/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:14:15
 * Version: 1.0.178
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
