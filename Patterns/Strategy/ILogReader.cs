/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 декабря 2025 06:51:49
 * Version: 1.0.117
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
