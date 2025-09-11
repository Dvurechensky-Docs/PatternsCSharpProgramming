/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 сентября 2025 06:52:03
 * Version: 1.0.25
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
