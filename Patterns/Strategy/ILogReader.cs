/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 февраля 2026 06:51:58
 * Version: 1.0.168
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
