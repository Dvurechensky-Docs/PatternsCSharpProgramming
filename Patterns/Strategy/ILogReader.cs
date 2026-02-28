/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:55:35
 * Version: 1.0.195
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
