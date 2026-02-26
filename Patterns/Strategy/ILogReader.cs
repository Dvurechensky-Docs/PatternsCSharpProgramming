/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 февраля 2026 06:52:07
 * Version: 1.0.193
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
