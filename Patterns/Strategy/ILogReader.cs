/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:54:03
 * Version: 1.0.219
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
