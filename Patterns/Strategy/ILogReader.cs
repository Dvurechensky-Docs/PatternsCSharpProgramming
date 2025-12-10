/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 декабря 2025 06:51:53
 * Version: 1.0.115
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
