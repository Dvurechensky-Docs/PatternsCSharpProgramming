/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 февраля 2026 07:55:12
 * Version: 1.0.175
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
