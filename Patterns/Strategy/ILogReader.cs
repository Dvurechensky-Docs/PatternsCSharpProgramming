/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 декабря 2025 13:36:18
 * Version: 1.0.107
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
