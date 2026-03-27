/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 марта 2026 11:51:29
 * Version: 1.0.222
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
