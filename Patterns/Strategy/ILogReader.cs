/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:33:02
 * Version: 1.0.179
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
