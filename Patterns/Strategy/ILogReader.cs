/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 ноября 2025 06:51:51
 * Version: 1.0.101
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
