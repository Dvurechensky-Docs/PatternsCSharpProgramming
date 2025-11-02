/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:23:12
 * Version: 1.0.77
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
