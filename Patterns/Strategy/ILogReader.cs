/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 ноября 2025 06:51:51
 * Version: 1.0.98
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
