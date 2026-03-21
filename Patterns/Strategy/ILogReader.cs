/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 марта 2026 07:33:17
 * Version: 1.0.215
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
