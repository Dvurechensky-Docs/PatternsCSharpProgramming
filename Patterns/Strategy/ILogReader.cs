/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2025 09:08:19
 * Version: 1.0.103
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
