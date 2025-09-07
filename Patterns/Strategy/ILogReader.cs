/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2025 10:48:30
 * Version: 1.0.21
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
