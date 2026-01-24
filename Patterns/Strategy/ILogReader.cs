/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 января 2026 09:18:12
 * Version: 1.0.160
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
