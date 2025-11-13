/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:51:53
 * Version: 1.0.88
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
