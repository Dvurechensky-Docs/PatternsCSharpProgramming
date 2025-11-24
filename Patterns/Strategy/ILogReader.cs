/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 ноября 2025 12:26:28
 * Version: 1.0.99
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
