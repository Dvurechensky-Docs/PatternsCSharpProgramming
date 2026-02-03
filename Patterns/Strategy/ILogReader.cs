/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 февраля 2026 06:51:52
 * Version: 1.0.170
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
