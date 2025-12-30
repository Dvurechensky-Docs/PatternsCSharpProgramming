/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 декабря 2025 10:15:52
 * Version: 1.0.135
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
