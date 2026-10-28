/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 октября 2026 10:18:26
 * Version: 1.0.439
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
