/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 ноября 2025 06:51:50
 * Version: 1.0.100
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
