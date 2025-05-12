/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 03:31:02
 * Version: 1.0.7
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
