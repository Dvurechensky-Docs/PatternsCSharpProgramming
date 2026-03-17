/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 марта 2026 06:52:09
 * Version: 1.0.211
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
