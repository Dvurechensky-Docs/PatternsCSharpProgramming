/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 января 2026 06:51:52
 * Version: 1.0.166
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
