/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 сентября 2025 11:50:36
 * Version: 1.0.40
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
