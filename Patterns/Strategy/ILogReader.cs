/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 сентября 2025 06:51:56
 * Version: 1.0.44
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
