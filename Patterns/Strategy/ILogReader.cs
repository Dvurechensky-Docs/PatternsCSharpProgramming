/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 марта 2026 06:52:04
 * Version: 1.0.214
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
