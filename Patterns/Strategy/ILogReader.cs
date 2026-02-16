/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 февраля 2026 12:48:12
 * Version: 1.0.183
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
