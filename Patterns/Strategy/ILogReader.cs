/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2026 06:51:16
 * Version: 1.0.455
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
