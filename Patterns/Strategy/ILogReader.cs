/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 сентября 2025 06:52:03
 * Version: 1.0.32
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
