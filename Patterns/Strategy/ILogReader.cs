/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 сентября 2025 06:52:00
 * Version: 1.0.38
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
