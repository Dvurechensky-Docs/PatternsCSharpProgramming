/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:42:45
 * Version: 1.0.194
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
