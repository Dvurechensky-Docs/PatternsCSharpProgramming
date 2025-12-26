/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:31:39
 * Version: 1.0.131
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
