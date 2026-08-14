/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 августа 2026 08:15:52
 * Version: 1.0.365
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
