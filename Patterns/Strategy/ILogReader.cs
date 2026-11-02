/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2026 09:37:54
 * Version: 1.0.444
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
