/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 февраля 2026 06:51:54
 * Version: 1.0.169
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
