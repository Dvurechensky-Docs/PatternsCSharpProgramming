/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:30:02
 * Version: 1.0.26
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
