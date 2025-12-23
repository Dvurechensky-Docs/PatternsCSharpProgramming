/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:47:40
 * Version: 1.0.128
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
