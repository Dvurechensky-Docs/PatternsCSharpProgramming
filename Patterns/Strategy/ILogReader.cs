/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:33:25
 * Version: 1.0.177
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
