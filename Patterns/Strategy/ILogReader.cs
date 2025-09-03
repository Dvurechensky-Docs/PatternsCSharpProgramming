/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:57:04
 * Version: 1.0.17
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
