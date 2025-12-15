/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 декабря 2025 06:51:54
 * Version: 1.0.120
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
