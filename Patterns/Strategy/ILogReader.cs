/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 февраля 2026 06:51:57
 * Version: 1.0.176
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
