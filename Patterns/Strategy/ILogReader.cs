/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 сентября 2025 06:51:57
 * Version: 1.0.36
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
