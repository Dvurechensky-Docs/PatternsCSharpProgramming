/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 сентября 2025 06:51:58
 * Version: 1.0.39
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
