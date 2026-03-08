/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 марта 2026 09:56:06
 * Version: 1.0.203
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
