/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:33:04
 * Version: 1.0.104
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
