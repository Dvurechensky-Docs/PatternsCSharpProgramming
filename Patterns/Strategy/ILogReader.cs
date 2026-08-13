/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 августа 2026 06:51:45
 * Version: 1.0.364
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
