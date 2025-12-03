/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:20:20
 * Version: 1.0.108
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
