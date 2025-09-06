/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:46:18
 * Version: 1.0.20
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
