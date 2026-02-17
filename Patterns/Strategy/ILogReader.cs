/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 февраля 2026 09:26:20
 * Version: 1.0.184
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
