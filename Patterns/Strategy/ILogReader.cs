/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 марта 2026 06:51:54
 * Version: 1.0.199
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
