/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 ноября 2025 06:52:15
 * Version: 1.0.85
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
