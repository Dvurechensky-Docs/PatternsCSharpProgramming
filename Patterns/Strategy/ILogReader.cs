/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 марта 2026 09:15:03
 * Version: 1.0.205
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
