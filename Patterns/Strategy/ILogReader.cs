/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 сентября 2025 06:51:58
 * Version: 1.0.31
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
