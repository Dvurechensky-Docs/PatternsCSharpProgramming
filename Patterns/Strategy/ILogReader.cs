/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 ноября 2026 10:47:51
 * Version: 1.0.468
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
