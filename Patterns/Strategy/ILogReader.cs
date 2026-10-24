/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 октября 2026 10:26:05
 * Version: 1.0.435
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
