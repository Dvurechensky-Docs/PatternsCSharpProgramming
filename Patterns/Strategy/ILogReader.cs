/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:51:46
 * Version: 1.0.132
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
