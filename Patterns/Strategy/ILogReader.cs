/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:53:37
 * Version: 1.0.86
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
