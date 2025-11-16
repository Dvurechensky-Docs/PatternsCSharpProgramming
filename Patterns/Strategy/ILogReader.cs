/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 ноября 2025 06:51:52
 * Version: 1.0.91
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
