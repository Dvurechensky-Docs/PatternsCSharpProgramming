/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 марта 2026 06:52:05
 * Version: 1.0.206
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
