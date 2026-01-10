/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 января 2026 06:51:51
 * Version: 1.0.146
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
