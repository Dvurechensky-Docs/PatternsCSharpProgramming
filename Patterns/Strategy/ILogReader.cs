/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 сентября 2025 14:15:22
 * Version: 1.0.34
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
