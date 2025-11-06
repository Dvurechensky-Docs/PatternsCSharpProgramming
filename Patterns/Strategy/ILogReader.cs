/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 ноября 2025 06:51:56
 * Version: 1.0.81
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
