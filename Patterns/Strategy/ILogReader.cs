/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 января 2026 06:51:59
 * Version: 1.0.164
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
