/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 16:01:16
 * Version: 1.0.118
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
