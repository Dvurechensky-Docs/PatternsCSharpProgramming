/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:09:55
 * Version: 1.0.126
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
